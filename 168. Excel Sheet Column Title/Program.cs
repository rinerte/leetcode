public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder("");
            while (columnNumber > 0)
            {
                columnNumber--;
                char c = (char)('A' + columnNumber % 26);
                columnNumber /= 26;
                sb.Insert(0, c);
            }
            return sb.ToString();
}   