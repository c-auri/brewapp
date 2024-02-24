namespace api;

public class TeaRepository 
{
    private static readonly Tea[] teas = new[]
    {
        new Tea(
            "Pretty Girls Mini",
            "https://white2tea.com/products/2021-pretty-girls-mini"),
        new Tea(
            "Smokeshou Mini",
            "https://white2tea.com/products/2021-smokeshou-mini"),
        new Tea(
            "Hokum Mini",
            "https://white2tea.com/products/2021-hokum-minis"),
        new Tea(
            "Lesser Evils Mini",
            "https://white2tea.com/products/2021-lesser-evils-minis"),
        new Tea(
            "Tale Chaser Mini",
            "https://white2tea.com/products/2022-tale-chaser-minis"),
        new Tea(
            "Lumber Mini",
            "https://white2tea.com/products/2022-lumber-minis"),
        new Tea(
            "Predawn Dark Mini",
            "https://white2tea.com/products/2023-predawn-dark-minis"),
        new Tea(
            "Stubb Mini", 
            "https://white2tea.com/products/2023-stubb-minis"),
        new Tea(
            "Prosbloom Mini",
            "https://white2tea.com/products/2023-prosbloom-mini"),
        new Tea(
            "Big O V3 Mini",
            "https://white2tea.com/products/2023-big-o-v3-mini"),
        new Tea(
            "Reading Room Mini", 
            "https://white2tea.com/products/2023-reading-room-mini"),
        new Tea(
            "Red Loon Mini",
            "https://white2tea.com/products/2023-red-loon-mini"),
        new Tea(
            "Glass House Mini",
            "https://white2tea.com/products/2023-glass-house-mini"),
    };

    internal IEnumerable<Tea> Get()
    {
        return teas;
    }
}
