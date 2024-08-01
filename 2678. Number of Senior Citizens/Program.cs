// You are given a 0-indexed array of strings details. Each element of details provides information about a given passenger compressed into a string of length 15. The system is such that:

// The first ten characters consist of the phone number of passengers.
// The next character denotes the gender of the person.
// The following two characters are used to indicate the age of the person.
// The last two characters determine the seat allotted to that person.
// Return the number of passengers who are strictly more than 60 years old.
public int CountSeniors(string[] details) {
    int count = 0;
    foreach(string s in details)
    if(Parse(s)>60) count++;
    return count;
}

int Parse(string s){
    return Convert.ToInt32(s.Substring(11,2));
}