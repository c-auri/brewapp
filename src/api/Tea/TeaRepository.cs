namespace api;

public class TeaRepository 
{
    private static readonly Tea[] teas = new[]
    {
        new Tea(
            1,
            "Pretty Girls Mini",
            "https://white2tea.com/products/2021-pretty-girls-mini"),
        new Tea(
            2,
            "Smokeshou Mini",
            "https://white2tea.com/products/2021-smokeshou-mini"),
        new Tea(
            3,
            "Hokum Mini",
            "https://white2tea.com/products/2021-hokum-minis"),
        new Tea(
            4,
            "Lesser Evils Mini",
            "https://white2tea.com/products/2021-lesser-evils-minis"),
        new Tea(
            5,
            "Tale Chaser Mini",
            "https://white2tea.com/products/2022-tale-chaser-minis"),
        new Tea(
            6,
            "Lumber Mini",
            "https://white2tea.com/products/2022-lumber-minis"),
        new Tea(
            7,
            "Predawn Dark Mini",
            "https://white2tea.com/products/2023-predawn-dark-minis"),
        new Tea(
            8,
            "Stubb Mini", 
            "https://white2tea.com/products/2023-stubb-minis"),
        new Tea(
            9,
            "Prosbloom Mini",
            "https://white2tea.com/products/2023-prosbloom-mini"),
        new Tea(
            10,
            "Big O V3 Mini",
            "https://white2tea.com/products/2023-big-o-v3-mini"),
        new Tea(
            11,
            "Reading Room Mini", 
            "https://white2tea.com/products/2023-reading-room-mini"),
        new Tea(
            12,
            "Red Loon Mini",
            "https://white2tea.com/products/2023-red-loon-mini"),
        new Tea(
            13,
            "Glass House Mini",
            "https://white2tea.com/products/2023-glass-house-mini"),
    };

    internal IEnumerable<Tea> Get()
    {
        return teas;
    }
}
