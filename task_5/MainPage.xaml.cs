using System.Collections.ObjectModel;

namespace Shop;

public partial class MainPage : ContentPage
{
    ObservableCollection<Item> items = new()
    {
        new Item(29.99, "Germany", "Gadget", new DateOnly(2023, 6, 15), "A fancy gadget."),
        new Food(29.99, "Bolivia", "Banana", new DateOnly(2023, 6, 15), "Ripe bananas",
                 new DateOnly(2023, 7, 1), 5, "units"),
        new Books(15.50, "USA", "Clean Code", new DateOnly(2023, 3, 10), "A handbook of good code",
                  464, "Prentice Hall", "Robert C. Martin")
    };

    public MainPage()
    {
        InitializeComponent();
        ItemsList.ItemsSource = items;
    }
    void OnAddFoodClicked(object sender, EventArgs e)
    {
        items.Add(new Food(25, "Ukraine", "Milk", new DateOnly(2026, 11, 2), "Fresh milk",
                           new DateOnly(2026, 11, 9), 2, "l"));
    }

    void OnAddBookClicked(object sender, EventArgs e)
    {
        items.Add(new Books(12.5, "UK", "1984", new DateOnly(2026, 1, 1), "Dystopian novel",
                            328, "Secker & Warburg", "George Orwell"));
    }

    void OnRemoveItemClicked(object sender, EventArgs e)
    {
        if (ItemsList.SelectedItem is Item selected)
            items.Remove(selected);
    }
}

