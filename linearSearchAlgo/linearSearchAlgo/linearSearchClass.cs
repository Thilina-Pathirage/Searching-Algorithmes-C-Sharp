namespace linearSearchAlgo
{
    internal class linearSearchClass
    {
        public int linearSearch( int [] items, int sk)
        {

            for (int i = 0; i < items.Length; i++) 
            {
                if (items[i] == sk) 
                {
                    return i;
                }
            }
            return -1;
        }

    }
}