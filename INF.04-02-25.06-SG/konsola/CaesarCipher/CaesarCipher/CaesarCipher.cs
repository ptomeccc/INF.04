public class CaesarCipher
{
    private string text;
    private int key;

    public CaesarCipher(string text, int key)
    {
        this.text = text.ToLower();
        this.key = key;
    }
    
    public string encrypt()
    {
        string result = "";
        char[] alfArray = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] textArray = text.ToCharArray();

        for (int i = 0; i < textArray.Length; i++)
        {
            if (!char.IsLetter(textArray[i]))
            {
                result += textArray[i];
            }
            else
            {
                for (int j = 0; j < alfArray.Length; j++)
                {
                    if (textArray[i] == alfArray[j])
                    {
                        result += alfArray[((j + key) % 26 + 26) % 26];
                        break;
                        
                    }
                }
            }
        }
        return result;
    }
}