namespace Algorithm_A_Day.Clash_of_Code
{
    // descriptions of tasks in  yt video 
    // https://www.youtube.com/watch?v=Aoy2MRvYK2A&t=146s
    public class IpAddress
    {
        public int GetPort(string ip)
        {
            if (ip.Length < 1) return -1;
            int firstDigit = ip[0];
            double summ = 0;

            foreach (char c in ip)
            {
                if (c != '.' && char.IsNumber(c) && char.IsDigit(c))
                {
                    summ += char.GetNumericValue(c);
                }
            }
            return (int)summ * firstDigit;
        }
    }
}
