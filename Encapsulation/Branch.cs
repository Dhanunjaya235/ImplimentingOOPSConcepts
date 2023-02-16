namespace Encapsulation
{
    public class Branch
    {
        private readonly string ifsc;

        public string IFSC { get { return ifsc; } }

        public Branch(string ifsc)
        {
            this.ifsc = ifsc;
        }
    }
}
