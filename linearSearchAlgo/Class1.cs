using System;

public class linearSearchClass
{
	public linearSearchMethod(int[] items, int sk)
	{

		for (int i = 0; i < items.Length; i++) 
		{
			if (items[i] == sk)
			{
				return items[i];
			}
		}

		return -1;
	}
}
