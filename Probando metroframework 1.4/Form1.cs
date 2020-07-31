using ExportPDF.Properties;

namespace ExportPDF
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //DEPRECATE
        //private static ImageList imagenes_imageList = new ImageList();
        //private static LinkedList<System.Drawing.Image> imagenes_list = new LinkedList<System.Drawing.Image>();

        private LinkedList<string> direcciones_list = new LinkedList<string>();
        private LinkedList<string> nombre_fotos = new LinkedList<string>();
        private OpenFileDialog ofd = new OpenFileDialog();
        private SaveFileDialog sfd = new SaveFileDialog();
        private Thread hilo_cargar_fotos = null;
        private Thread hilo_exportar_pdf = null;
        private static int calidad = 0;

        #region Delegates
        //private delegate void delegado();
        //delegado delegado_llenar_list_view;

        private delegate void delegado2(bool activo);
        delegado2 delegado_cargando_spinner;

        private delegate void delegado3(bool enable);
        delegado3 delegado_enable_form;

        private delegate void delegado4(double porciento);
        delegado4 delegado_porciento;

        private delegate void delegado5(int cantidad);
        delegado5 delegado_cantidad;

        private delegate void delegado6(string nombre, string url);
        delegado6 delegado_insertar_en_datagridview;

        private delegate void delegado7(bool state);
        delegado7 delegado_enable_export_delete;

        #endregion
        public Form1()
        {
            //imagenes_imageList.ImageSize = new Size(120, 150);
            //imagenes_imageList.ColorDepth = ColorDepth.Depth32Bit;
            InitializeComponent();
        }

        private void importar_metroTile_Click(object sender, EventArgs e)
        {
            hilo_cargar_fotos = new Thread(new ThreadStart(Cargar_fotos));
            hilo_cargar_fotos.ApartmentState = ApartmentState.STA;
            hilo_cargar_fotos.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exportar_pdf_metroTile.Enabled = false;
            eliminar_metroTile.Enabled = false;
            porciento_metroLabel.Text = "";
            imagenes_metroGrid.Columns.Add("nombre", "Nombre");
            imagenes_metroGrid.Columns.Add("url", "Dirección");
            cargando_metroProgressSpinner.Visible = false;
            //delegado_llenar_list_view = llenar_imagens_listView;
            delegado_cargando_spinner = Cargando_spinner;
            delegado_enable_form = Enable_form;
            delegado_porciento = Porciento;
            delegado_cantidad = Cantidad;
            delegado_insertar_en_datagridview = Insertar_en_datagridview;
            delegado_enable_export_delete = Enable_export_delete;
            //imagenes_listView.LargeImageList = imagenes_imageList;
            //imagenes_listView.SmallImageList = imagenes_imageList;
            //imagenes_listView.StateImageList = imagenes_imageList;
        }
        
        private void exportar_pdf_metroTile_Click(object sender, EventArgs e)
        {
            hilo_exportar_pdf = new Thread(new ThreadStart(Exportar_pdf));
            hilo_exportar_pdf.ApartmentState = ApartmentState.STA;
            hilo_exportar_pdf.Start();
        }

        private void Exportar_pdf()
        {
            sfd.Title = "Guardar";
            sfd.Filter = "Pdf (*.pdf) | *.pdf";
            DialogResult dr = sfd.ShowDialog();
            string direccion = sfd.FileName;
            if (dr == DialogResult.OK)
            {
                Invoke(delegado_cargando_spinner, true);
                Invoke(delegado_enable_form, false);
                int direcciones_lista_posicion = 0;
                double porciento = 0;
                Document document = new Document(PageSize.LETTER);
                PdfWriter.GetInstance(document, new FileStream(direccion, FileMode.OpenOrCreate));
                document.Open();
                //Creacion de la letra*******************************************************
                //Letra a usar Bebas Neue
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);
                iTextSharp.text.Font bebasNeue = new iTextSharp.text.Font(FontFactory.GetFont("Times New Roman", 10, iTextSharp.text.BaseColor.WHITE));
                Console.WriteLine(FontFactory.IsRegistered("Bebas Neue"));
                
                iTextSharp.text.Image inicio = null;
                if (calidad == 1)
                {
                    inicio = iTextSharp.text.Image.GetInstance(Resources.inicio, ImageFormat.Jpeg);
                }
                else if (calidad == 0)
                {
                    inicio = iTextSharp.text.Image.GetInstance(Resources.inicio_low, ImageFormat.Jpeg);
                }
                inicio.SetAbsolutePosition(0, 0);
                inicio.ScaleAbsoluteWidth(document.PageSize.Width);
                inicio.ScaleAbsoluteHeight(document.PageSize.Height);
                document.Add(inicio);
                while (direcciones_lista_posicion < direcciones_list.Count)
                {
                    document.NewPage();
                    //Aqui pongo y gestiono el fondo*********************************
                    #region Aqui pongo y gestiono el fondo
                    iTextSharp.text.Image fondo = null;
                    if (calidad == 1)
                    {
                        fondo = iTextSharp.text.Image.GetInstance(Resources.fondo_pdf, ImageFormat.Jpeg);
                    }
                    else if (calidad == 0)
                    {
                        fondo = iTextSharp.text.Image.GetInstance(Resources.fondo_pdf_low, ImageFormat.Jpeg);
                    }
                    fondo.SetAbsolutePosition(0, 0);
                    fondo.ScaleAbsoluteWidth(document.PageSize.Width);
                    fondo.ScaleAbsoluteHeight(document.PageSize.Height);
                    document.Add(fondo);
                    #endregion

                    //Creacion de la tabla***************************************************
                    PdfPTable tblPrueba = new PdfPTable(4);
                    tblPrueba.WidthPercentage = 100;

                    //Generacion del row*********************************************************
                    for (int i = 0; i < 4; i++)
                    {
                        PdfPCell[] celdas = new PdfPCell[4];
                        if (direcciones_lista_posicion < direcciones_list.Count)
                        {
                            //Celda 1****************************************************************
                            PdfPCell celda_1 = new PdfPCell();
                            celda_1.BorderWidth = 0;
                            System.Drawing.Image imgTemp1 = System.Drawing.Image.FromFile(direcciones_list.ElementAt(direcciones_lista_posicion));
                            iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(CambiarTamanoImagen(imgTemp1, 480, 640), ImageFormat.Jpeg);
                            celda_1.AddElement(imagen1);
                            Paragraph titulo1 = new Paragraph(nombre_fotos.ElementAt(direcciones_lista_posicion), bebasNeue);
                            titulo1.Alignment = Element.ALIGN_CENTER;
                            celda_1.AddElement(titulo1);
                            celda_1.PaddingTop = 10;
                            direcciones_lista_posicion++;
                            porciento = direcciones_lista_posicion / (double)direcciones_list.Count * 100;
                            Invoke(delegado_porciento, porciento);
                            celdas[0] = celda_1;
                        }

                        if (direcciones_lista_posicion < direcciones_list.Count)
                        {
                            //Celda 2****************************************************************
                            PdfPCell celda_2 = new PdfPCell();
                            celda_2.BorderWidth = 0;
                            System.Drawing.Image imgTemp2 = System.Drawing.Image.FromFile(direcciones_list.ElementAt(direcciones_lista_posicion));
                            iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance(CambiarTamanoImagen(imgTemp2, 480, 640), ImageFormat.Jpeg);
                            celda_2.AddElement(imagen2);
                            Paragraph titulo2 = new Paragraph(nombre_fotos.ElementAt(direcciones_lista_posicion), bebasNeue);
                            titulo2.Alignment = Element.ALIGN_CENTER;
                            celda_2.AddElement(titulo2);
                            celda_2.PaddingTop = 10;
                            direcciones_lista_posicion++;
                            porciento = direcciones_lista_posicion / (double)direcciones_list.Count * 100;
                            Invoke(delegado_porciento, porciento);
                            celdas[1] = celda_2;
                        }

                        if (direcciones_lista_posicion < direcciones_list.Count)
                        {
                            //Celda 3****************************************************************
                            PdfPCell celda_3 = new PdfPCell();
                            celda_3.BorderWidth = 0;
                            System.Drawing.Image imgTemp3 = System.Drawing.Image.FromFile(direcciones_list.ElementAt(direcciones_lista_posicion));
                            iTextSharp.text.Image imagen3 = iTextSharp.text.Image.GetInstance(CambiarTamanoImagen(imgTemp3, 480, 640), ImageFormat.Jpeg);
                            celda_3.AddElement(imagen3);
                            Paragraph titulo3 = new Paragraph(nombre_fotos.ElementAt(direcciones_lista_posicion), bebasNeue);
                            titulo3.Alignment = Element.ALIGN_CENTER;
                            celda_3.AddElement(titulo3);
                            celda_3.PaddingTop = 10;
                            direcciones_lista_posicion++;
                            porciento = direcciones_lista_posicion / (double)direcciones_list.Count * 100;
                            Invoke(delegado_porciento, porciento);
                            celdas[2] = celda_3;
                        }

                        if (direcciones_lista_posicion < direcciones_list.Count)
                        {
                            //Celda 4****************************************************************
                            PdfPCell celda_4 = new PdfPCell();
                            celda_4.BorderWidth = 0;
                            System.Drawing.Image imgTemp4 = System.Drawing.Image.FromFile(direcciones_list.ElementAt(direcciones_lista_posicion));
                            iTextSharp.text.Image imagen4 = iTextSharp.text.Image.GetInstance(CambiarTamanoImagen(imgTemp4, 480, 640), ImageFormat.Jpeg);
                            celda_4.AddElement(imagen4);
                            Paragraph titulo4 = new Paragraph(nombre_fotos.ElementAt(direcciones_lista_posicion), bebasNeue);
                            titulo4.Alignment = Element.ALIGN_CENTER;
                            celda_4.AddElement(titulo4);
                            celda_4.PaddingTop = 10;
                            direcciones_lista_posicion++;
                            porciento = direcciones_lista_posicion / (double)direcciones_list.Count * 100;
                            Invoke(delegado_porciento, porciento);
                            celdas[3] = celda_4;
                        }
                         
                        else
                        {
                            break;
                        }

                        tblPrueba.Rows.Add(new PdfPRow(celdas));

                    }
                    
                    document.Add(tblPrueba);

                    



                    /*int x_inicial = 40;
                    int y_inicial = 575;
                    if (direcciones_lista_posicion < direcciones_list.Count)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (direcciones_lista_posicion < direcciones_list.Count)
                                {
                                    if (habilitar_fondo_blanco_metroCheckBox.Checked)
                                    {
                                        iTextSharp.text.Image fondo_blanco = null;
                                        if (calidad == 1)
                                        {
                                            fondo_blanco = fondo_blanco = iTextSharp.text.Image.GetInstance(Resources.fondo_blanco, ImageFormat.Png);
                                        }
                                        else if (calidad == 0)
                                        {
                                            fondo_blanco = fondo_blanco = iTextSharp.text.Image.GetInstance(Resources.fondo_blanco_low, ImageFormat.Png);
                                        }
                                        fondo_blanco.SetAbsolutePosition(x_inicial - 8, y_inicial - 10);
                                        fondo_blanco.ScaleAbsoluteWidth((document.PageSize.Width * 20 / 100) + 16);
                                        fondo_blanco.ScaleAbsoluteHeight((document.PageSize.Height * 19 / 100) + 20);
                                        document.Add(fondo_blanco);
                                    }
                                    iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(direcciones_list.ElementAt(direcciones_lista_posicion));
                                    imagen1.SetAbsolutePosition(x_inicial, y_inicial);
                                    imagen1.ScaleAbsoluteWidth(document.PageSize.Width * 20 / 100);
                                    imagen1.ScaleAbsoluteHeight(document.PageSize.Height * 19 / 100);
                                    document.Add(imagen1);
                                    direcciones_lista_posicion++;
                                    x_inicial += (int)document.PageSize.Width * 20 / 100 + 15;
                                    porciento = direcciones_lista_posicion / (double)direcciones_list.Count * 100;
                                    Invoke(delegado_porciento, porciento);
                                }
                            }
                            x_inicial = 40;
                            y_inicial -= (int)document.PageSize.Height * 19 / 100 + 20;
                        }
                    }*/
                }
                //document.AddAuthor("Alejandro Giubel Hernández Arbelo");
                document.AddCreationDate();
                //document.AddCreator("Alejandro Giubel Hernández Arbelo");
                document.AddTitle(titulo_metroTextBox.Text);
                document.Close();
                Invoke(delegado_cargando_spinner, false);
                Invoke(delegado_enable_form, true);
                hilo_exportar_pdf.Abort();
            }
        }
        private void Cargar_fotos()
        {
            double porciento = 0;
            // Set the file dialog to filter for graphics files.
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG| All files (*.*)|*.*";

            // Allow the user to select multiple images.
            ofd.Multiselect = true;
            ofd.Title = "Seleccione las imágenes";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Invoke(delegado_cargando_spinner, true);
                Invoke(delegado_enable_form, false);
                // Read the files
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    porciento = (i + 1) / (double) ofd.FileNames.Length * 100;
                    //System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileNames[i]);
                    //imagenes_imageList.Images.Add(img);
                    //imagenes_list.AddLast(img);
                    //imagenes_list.ElementAt(i).Tag = ofd.FileNames[i];
                    direcciones_list.AddLast(ofd.FileNames[i]);
                    nombre_fotos.AddLast(ofd.SafeFileNames[i].Split('.')[0]);
                    Invoke(delegado_insertar_en_datagridview, ofd.SafeFileNames[i], ofd.FileNames[i]);
                    Invoke(delegado_porciento, porciento);
                    Invoke(delegado_cantidad, i + 1);
                }
                //Invoke(delegado_llenar_list_view);
                Invoke(delegado_enable_export_delete, true);
                Invoke(delegado_cargando_spinner, false);
                Invoke(delegado_enable_form, true);
                hilo_cargar_fotos.Abort();
            }
        }

        private void Cargando_spinner(bool activo)
        {
            cargando_metroProgressSpinner.Visible = activo;
            porciento_metroLabel.Visible = activo;
        }

        private void Enable_form(bool enable)
        {
            importar_metroTile.Enabled = enable;
            exportar_pdf_metroTile.Enabled = enable;
            eliminar_metroTile.Enabled = enable;
            titulo_metroTextBox.Enabled = enable;
            habilitar_fondo_blanco_metroCheckBox.Enabled = enable;
            calidad_metroComboBox.Enabled = enable;
        }

        private void Porciento(double porciento)
        {
            porciento_metroLabel.Text = (int) porciento + "%";
        }

        private void Cantidad(int cantidad)
        {
            cantidad_imagenes_mostrar_metroLabel.Text = cantidad.ToString();
        }

        private void Eliminar_metroTile_Click(object sender, EventArgs e)
        {
            direcciones_list.Clear();
            imagenes_metroGrid.Rows.Clear();
            imagenes_metroGrid.Columns.Clear();
            imagenes_metroGrid.ScrollBars = ScrollBars.None;
            imagenes_metroGrid.Refresh();
            cantidad_imagenes_mostrar_metroLabel.Text = "";
            exportar_pdf_metroTile.Enabled = false;
            eliminar_metroTile.Enabled = false;
        }

        private void Insertar_en_datagridview(string nombre, string url)
        {
            imagenes_metroGrid.Rows.Add(nombre, url);
        }

        private void calidad_metroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calidad_metroComboBox.SelectedItem.ToString().Equals("Alta"))
                calidad = 1;
            else
                calidad = 0;
        }

        private void Enable_export_delete(bool state)
        {
            exportar_pdf_metroTile.Enabled = state;
            eliminar_metroTile.Enabled = state;
        }

        public System.Drawing.Image CambiarTamanoImagen(System.Drawing.Image pImagen, int pAncho, int pAlto)
	    {
	        //creamos un bitmap con el nuevo tamaño
	        Bitmap vBitmap = new Bitmap(pAncho, pAlto);
	        //creamos un graphics tomando como base el nuevo Bitmap
	        using (Graphics vGraphics = Graphics.FromImage((System.Drawing.Image) vBitmap))
	        {
	            //especificamos el tipo de transformación, se escoge esta para no perder calidad.
	            vGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
	            //Se dibuja la nueva imagen
	            vGraphics.DrawImage(pImagen, 0, 0, pAncho, pAlto);
	        }
	        //retornamos la nueva imagen
	        return (System.Drawing.Image) vBitmap;
	    }


    }

}
