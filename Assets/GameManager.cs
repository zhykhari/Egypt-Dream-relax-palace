using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    
    public Text titleText;
    public Image pictureImage;
    public Text descriptionText;
    public Text aboutUsText;

    public Text[] titles;
    public Image[] images;
    public string[] descriptions;
    public GameObject ProdDetailPanel, ProdTopBar,MenuPanel;
    public Text topBarText;
    public void changeTopBarText(string newText)
    {
        topBarText.text = newText;
    }
    private void Start()
    {
        aboutUsText.text = "Welcome to Oasis, a unique dining and cocktail bar experience that transports you to a tropical paradise right in the heart of the city. At Oasis, we blend exquisite culinary creations with handcrafted cocktails, creating a haven where flavors and relaxation intertwine.\n\n" +
    "Our menu is a fusion of global inspirations, taking you on a culinary journey that explores diverse flavors and textures. From tantalizing appetizers to mouthwatering main courses, our talented chefs artfully combine the finest ingredients to create culinary masterpieces that will delight your taste buds.\n\n" +
    "Step into our cocktail bar, where our skilled mixologists craft a menu of signature cocktails that are as refreshing as they are innovative. From classic favorites to unique concoctions, our bartenders use premium spirits, fresh ingredients, and a dash of creativity to create cocktails that are truly unforgettable.\n\n" +
    "At Oasis, we believe that dining and drinking is an experience to be savored. Our warm and inviting ambiance, reminiscent of a tropical paradise, sets the stage for unforgettable moments with friends and loved ones. Whether you're celebrating a special occasion, enjoying a casual night out, or seeking an oasis of relaxation, our dedicated staff is here to ensure your visit is nothing short of extraordinary.\n\n" +
    "Escape to Oasis and indulge in the flavors of paradise. We invite you to experience the perfect blend of culinary excellence, captivating cocktails, and tropical ambiance that awaits you at our restaurant and cocktail bar.";

        descriptions[0] = "Indulge in the refreshing sweetness of our delightful Strawberry Shake. Made with ripe, luscious strawberries and creamy goodness, this classic milkshake is the perfect treat for any time of the day. Our skilled chefs have crafted this menu item to offer a burst of fruity flavors that will leave your taste buds dancing with joy.\n\nIngredients:\n\n" +
    "- Fresh, ripe strawberries\n" +
    "- Creamy vanilla ice cream\n" +
    "- Chilled milk\n" +
    "- Whipped cream\n" +
    "- Strawberry syrup\n" +
    "- A cherry on top (optional)\n" +
    "- Ice cubes (optional)";
descriptions[1] = "Quench your thirst with our refreshing Lemonades. Made with freshly squeezed lemons and a hint of sweetness, our lemonades are a delightful blend of tangy and sweet flavors that will leave you feeling rejuvenated.\n\nFlavors:\n\n" +
    "1. Classic Lemonade:\n" +
    "   - Freshly squeezed lemons\n" +
    "   - Chilled water\n" +
    "   - Sugar syrup\n" +
    "   - Ice cubes\n\n" +
    "2. Strawberry Lemonade:\n" +
    "   - Freshly squeezed lemons\n" +
    "   - Strawberry puree\n" +
    "   - Chilled water\n" +
    "   - Sugar syrup\n" +
    "   - Ice cubes\n\n" +
    "3. Mint Lemonade:\n" +
    "   - Freshly squeezed lemons\n" +
    "   - Fresh mint leaves\n" +
    "   - Chilled water\n" +
    "   - Sugar syrup\n" +
    "   - Ice cubes";

        descriptions[2] = "Explore the refreshing flavors of our indulgent Cold Drinks collection. Crafted with meticulous attention to detail, our cold drinks offer a delightful taste that will captivate beverage enthusiasts.\n\n" +
"Selection:\n\n" +
"1. Sparkling Lemonade:\n" +
" - Flavor: Zesty and tangy lemon burst\n" +
" - Ingredients: Sparkling water, freshly squeezed lemons, and a hint of sweetness\n" +
" - Taste: Crisp and revitalizing\n\n" +
"2. Iced Tea:\n" +
" - Flavor: Classic black tea with a hint of sweetness\n" +
" - Ingredients: Premium tea leaves, pure cane sugar, and a touch of lemon\n" +
" - Taste: Refreshing and rejuvenating\n\n" +
"3. Fruit Punch:\n" +
" - Flavor: Bursting with tropical fruit goodness\n" +
" - Ingredients: A medley of ripe fruits, including pineapple, mango, and passion fruit\n" +
" - Taste: Sweet, vibrant, and incredibly satisfying\n\n" +
"4. Creamy Milkshake:\n" +
" - Flavor: Indulgent blend of rich chocolate and creamy vanilla\n" +
" - Ingredients: Creamy milk, premium cocoa powder, and pure vanilla extract\n" +
" - Texture: Smooth, velvety, and utterly decadent";
        descriptions[3] = "Savor our mouthwatering Burger Deal, a perfect combination of juicy patties, fresh ingredients, and delectable flavors. Each burger is expertly crafted to satisfy your cravings and elevate your dining experience.\n\nBurger Deal:\n\n" +
    "Choose any burger from the following options:\n\n" +
    "1. Classic Cheeseburger:\n" +
    "   - Juicy beef patty\n" +
    "   - American cheese\n" +
    "   - Lettuce\n" +
    "   - Tomato\n" +
    "   - Pickles\n" +
    "   - Special sauce\n" +
    "   - Sesame seed bun\n\n" +
    "2. BBQ Bacon Burger:\n" +
    "   - Juicy beef patty\n" +
    "   - Crispy bacon\n" +
    "   - Cheddar cheese\n" +
    "   - BBQ sauce\n" +
    "   - Caramelized onions\n" +
    "   - Brioche bun\n\n" +
    "3. Veggie Burger:\n" +
    "   - Plant-based patty\n" +
    "   - Melted cheese\n" +
    "   - Lettuce\n" +
    "   - Tomato\n" +
    "   - Red onion\n" +
    "   - Special sauce\n" +
    "   - Whole wheat bun\n\n" +
    "Each burger comes with a side of crispy fries and a refreshing soft drink of your choice.";
        descriptions[4]= "Embark on a culinary journey with our delightful Chinese Deal. Our carefully curated selection of authentic Chinese dishes will transport you to the vibrant streets of China, offering a symphony of flavors and aromas.\n\nChinese Deal:\n\n" +
    "Enjoy the following dishes as part of our Chinese Deal:\n\n" +
    "1. Sweet and Sour Chicken:\n" +
    "   - Crispy chicken pieces\n" +
    "   - Tangy sweet and sour sauce\n" +
    "   - Bell peppers\n" +
    "   - Pineapple chunks\n" +
    "   - Served with steamed rice\n\n" +
    "2. Kung Pao Shrimp:\n" +
    "   - Succulent shrimp\n" +
    "   - Spicy Kung Pao sauce\n" +
    "   - Peanuts\n" +
    "   - Red chili peppers\n" +
    "   - Served with fried rice\n\n" +
    "3. Vegetable Chow Mein:\n" +
    "   - Stir-fried noodles\n" +
    "   - Assorted fresh vegetables\n" +
    "   - Savory soy sauce\n" +
    "   - Garlic and ginger\n" +
    "   - Served with crispy spring rolls\n\n" +
    "Complete your meal with a fortune cookie and a choice of hot tea or iced jasmine tea.";

        descriptions[5] = "Experience the flavors of Italy with our delectable Pasta selection. Each dish is crafted with the finest ingredients, perfectly cooked pasta, and mouthwatering sauces, delivering a taste of authentic Italian cuisine.\n\nPasta Selection:\n\n" +
    "1. Spaghetti Bolognese:\n" +
    "   - Al dente spaghetti\n" +
    "   - Rich Bolognese sauce\n" +
    "   - Ground beef\n" +
    "   - Diced tomatoes\n" +
    "   - Fresh herbs and spices\n\n" +
    "2. Fettuccine Alfredo:\n" +
    "   - Creamy Alfredo sauce\n" +
    "   - Tender fettuccine pasta\n" +
    "   - Grilled chicken strips\n" +
    "   - Parmesan cheese\n" +
    "   - Freshly ground black pepper\n\n" +
    "3. Pesto Linguine:\n" +
    "   - Linguine pasta tossed in homemade pesto sauce\n" +
    "   - Sun-dried tomatoes\n" +
    "   - Pine nuts\n" +
    "   - Grated Parmesan cheese\n" +
    "   - Fresh basil leaves\n\n" +
    "Complement your pasta dish with a side of garlic bread and a crisp Caesar salad.";

    }
    public void ChangeContent(int currentIndex)
    {
        MenuPanel.SetActive(false);
        ProdDetailPanel.SetActive(true);
        ProdTopBar.SetActive(true);
        ProdTopBar.SetActive(true);
        titleText.text = titles[currentIndex].text;
        pictureImage.sprite = images[currentIndex].sprite;
        descriptionText.text = descriptions[currentIndex];
    }
}
