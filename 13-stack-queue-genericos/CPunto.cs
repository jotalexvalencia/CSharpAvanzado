namespace _13_stack_queue_genericos
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
            return string.Format("X={0}, Y={1}", x, y);
        }
    }    
}
