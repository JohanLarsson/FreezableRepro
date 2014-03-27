namespace FreezableRepro
{
    using System.Collections.ObjectModel;
    using System.Windows;

    public class DummyCollection : UIElement
    {
        public DummyCollection()
        {
            Dummies = new ObservableCollection<Dummy>();
        }
        public ObservableCollection<Dummy> Dummies { get; set; }
    }
}
