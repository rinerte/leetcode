public bool CanPlaceFlowers(int[] flowerbed, int n) {
    int x = 0;

    for (int i = 0; i < flowerbed.Length; i++)
    {
        if (flowerbed[i] == 0 && ((i + 1 == flowerbed.Length) || flowerbed[i + 1] == 0) && (i - 1 < 0 || flowerbed[i - 1] == 0))
        {
            x++;
            flowerbed[i] = 1;
        }
    }
    return x >= n;
}