namespace FreezableRepro
{
    using System.Windows;

    public class Dummy : Freezable
    {
        public static readonly DependencyProperty WidthProperty = DependencyProperty.Register(
            "Width",
            typeof (double),
            typeof (Dummy),
            new PropertyMetadata(default(double)));

        public double Width
        {
            get
            {
                return (double) GetValue(WidthProperty);
            }
            set
            {
                SetValue(WidthProperty, value);
            }
        }
        public override string ToString()
        {
            return Width.ToString();
        }
        protected override Freezable CreateInstanceCore()
        {
            return new Dummy();
        }
    }
}
