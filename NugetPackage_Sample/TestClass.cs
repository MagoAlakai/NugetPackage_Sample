namespace NugetPackage_Sample
{
    public sealed class TestClass
    {
        private bool _test;
        public bool Test
        {
            get { return _test; }
            set
            {
                _test = !value;
            }
        }
    }
}