namespace ExportPDF.Logica
{
    class Imagenes
    {
        private ImageList imagenes_listview;
        private LinkedList<Image> lista_imagenes;

        public ImageList Imagenes_listview { get => imagenes_listview; set => imagenes_listview = value; }
        public LinkedList<Image> Lista_imagenes { get => lista_imagenes; set => lista_imagenes = value; }
    }
}
