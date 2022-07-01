
namespace StarkesPW
{
    class CheckStrongPw
    {
        public int countStrong;
        public string StrongPw()
        {
            if (PwConditions.uppCase)
            {
                countStrong++;
            }
            if (PwConditions.lowCase)
            {
                countStrong++;
            }
            if (PwConditions.hasNum)
            {
                countStrong++;
            }
            if (PwConditions.specChars)
            {
                countStrong++;
            }

            return countStrong.ToString();
        }
    }
}
