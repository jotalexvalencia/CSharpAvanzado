namespace _11_lista_generica_I
{
    class CPunto
    {
        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}",x,y);
        }

        
    }
}
