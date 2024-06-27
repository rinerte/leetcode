public int TitleToNumber(string columnTitle) {
        int result = 1;

            for(int i = 0; i < columnTitle.Length-1; i++)
            {
                result += (int)Math.Pow(26, columnTitle.Length - i - 1) * (columnTitle[i] - 'A' + 1);
            }
            result += (columnTitle[columnTitle.Length - 1] - 'A');
            return result;
}