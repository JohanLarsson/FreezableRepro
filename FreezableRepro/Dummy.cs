namespace FreezableRepro
{
    using System.Windows;

    public class Dummy : Freezable
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value",
            typeof(object),
            typeof(Dummy),
            new PropertyMetadata(null));

        public object Value
        {
            get
            {
                return (object)GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }
        public override string ToString()
        {
            return Value == null ? "null" : Value.ToString();
        }
        protected override Freezable CreateInstanceCore()
        {
            return new Dummy();
        }
    }
}
