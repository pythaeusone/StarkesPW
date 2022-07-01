
namespace StarkesPW
{
    class SetStrongPw
    {
        public void CheckChars(char c)
        {
            if(c >= 'A' && c <= 'Z')
            {
                PwConditions.uppCase = true;
            }
            if (c >= 'a' && c <= 'z')
            {
                PwConditions.lowCase = true;
            }
            if (c >= '0' && c <= '9')
            {
                PwConditions.hasNum = true;
            }
            if(c == '!' | c == '*')
            {
                PwConditions.specChars = true;
            }
        }
    }
}
