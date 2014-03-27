namespace FreezableRepro
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
        protected override Freezable CreateInstanceCore()
        {
            return new Dummy();
        }
    }
}
