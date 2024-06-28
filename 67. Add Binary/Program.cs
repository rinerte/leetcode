public string AddBinary(string a, string b) {
    var result = new StringBuilder("");
        
    int indexA = a.Length, indexB = b.Length, first,second,remainder = 0;

    Dictionary<char, int> map = new Dictionary<char, int>()
    {
        {'1',1 },
        {'0',0 }
    };

    while (indexA > 0 || indexB > 0 || remainder>0)
    {
        if(indexA > 0)
        {
            first = map[a[indexA-1]];
            indexA--;
        } else first = 0;
        if (indexB > 0)
        {
            second = map[b[indexB-1]];
            indexB--;
        }
        else second = 0;

        switch (first + second + remainder)
        {
            case 0:
                result.Insert(0,'0');
                break;
            case 1:
                result.Insert(0,'1');
                remainder = 0;
                break;
            case 2:
                result.Insert(0,'0');
                remainder = 1;
                break;
            case 3:
                result.Insert(0,'1');
                remainder = 1;
                break;
        }
    }
    return result.ToString();
}