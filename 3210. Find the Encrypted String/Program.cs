// You are given a string s and an integer k. Encrypt the string using the following algorithm:

// For each character c in s, replace c with the kth character after c in the string (in a cyclic manner).
// Return the encrypted string.
public string GetEncryptedString(string s, int k) {
    StringBuilder sb = new(s);
    for(int i=0; i<s.Length;i++){
        sb[i]=s[(i+k)%s.Length];
    }
    return sb.ToString();
}