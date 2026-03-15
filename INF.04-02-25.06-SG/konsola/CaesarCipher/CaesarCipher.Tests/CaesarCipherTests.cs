using Xunit;
public class CaesarCipherTests
{
    [Fact]
    public void Encrypt_With_Key_3_Length_Smaller_Than_Alphabet()
    {
        // Arange 
        CaesarCipher cipher = new CaesarCipher("abc", 3);
        
        // Act
        string result = cipher.encrypt();
        
        //Assert 
        Assert.Equal("def", result);
    }

    [Fact]
    public void Encrypt_With_Key_Leading_Out_Of_Alphabet()
    {
        // Arange 
        CaesarCipher cipher = new CaesarCipher("xyz", 3);
        
        // Act
        string result = cipher.encrypt();
        
        //Assert 
        Assert.Equal("abc", result);
    }
    
    [Fact]
    public void Decrypt_With_Negative_Key_3()
    {
        // Arange 
        CaesarCipher cipher = new CaesarCipher("def", -3);
        
        // Act
        string result = cipher.encrypt();
        
        //Assert 
        Assert.Equal("abc", result);
    }
    
    [Fact]
    public void Encrypt_With_Key_Bigger_Than_Alphabet_Length()
    {
        // Arange 
        CaesarCipher cipher = new CaesarCipher("abc", 29);
        
        // Act
        string result = cipher.encrypt();
        
        //Assert 
        Assert.Equal("def", result);
    }
    
    [Fact]
    public void Encrypt_With_Text_Having_Space()
    {
        // Arange 
        CaesarCipher cipher = new CaesarCipher("ab cd", 2);
        
        // Act
        string result = cipher.encrypt();
        
        //Assert 
        Assert.Equal("cd ef", result);
    }
}
