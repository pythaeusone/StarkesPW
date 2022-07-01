
namespace StarkesPW
{
    class SplitPW
    {
        public void PwSplit(string str)
        {
            SetStrongPw sspw = new SetStrongPw();

            foreach(char c in str)
            {
                sspw.CheckChars(c);
            }
        }
    }
}
