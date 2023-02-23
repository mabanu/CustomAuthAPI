using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomAuthAPI.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "UniqueStoreId", "Name" },
                values: new object[,]
                {
                    { 1, "Hansen and Sons" },
                    { 2, "Littel, Walter and Bartoletti" },
                    { 3, "Kassulke-Cole" },
                    { 4, "Steuber LLC" },
                    { 5, "Collier, Kassulke and Schinner" },
                    { 6, "Smith Group" },
                    { 7, "Rolfson, Pollich and McDermott" },
                    { 8, "Metz, Schaden and Bashirian" },
                    { 9, "Yundt-Russel" },
                    { 10, "Rice-Kovacek" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { 1, "Movies", "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", "http://dummyimage.com/162x100.png/ff4444/ffffff", "$3.56", 33, 7, "Star Bulk Carriers Corp." },
                    { 2, "Shoes", "Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy.", "http://dummyimage.com/133x100.png/ff4444/ffffff", "$3.90", 48, 1, "Sally Beauty Holdings, Inc." },
                    { 3, "Grocery", "Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", "http://dummyimage.com/204x100.png/5fa2dd/ffffff", "$5.75", 28, 5, "Anthera Pharmaceuticals, Inc." },
                    { 4, "Toys", "Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", "http://dummyimage.com/105x100.png/5fa2dd/ffffff", "$1.01", 48, 3, "Motorola Solutions, Inc." },
                    { 5, "Movies", "Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", "http://dummyimage.com/196x100.png/dddddd/000000", "$0.92", 26, 2, "Veritex Holdings, Inc." },
                    { 6, "Sports", "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", "http://dummyimage.com/172x100.png/cc0000/ffffff", "$9.57", 33, 2, "PowerShares S&P SmallCap Energy Portfolio" },
                    { 7, "Beauty", "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", "http://dummyimage.com/184x100.png/cc0000/ffffff", "$2.81", 48, 10, "Leading Brands Inc" },
                    { 8, "Baby", "Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.", "http://dummyimage.com/150x100.png/cc0000/ffffff", "$0.39", 49, 5, "BiondVax Pharmaceuticals Ltd." },
                    { 9, "Clothing", "Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", "http://dummyimage.com/155x100.png/ff4444/ffffff", "$4.32", 5, 6, "MKS Instruments, Inc." },
                    { 10, "Garden", "Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", "http://dummyimage.com/246x100.png/dddddd/000000", "$8.57", 48, 6, "MediWound Ltd." },
                    { 11, "Games", "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", "http://dummyimage.com/206x100.png/ff4444/ffffff", "$4.55", 46, 4, "Just Energy Group, Inc." },
                    { 12, "Industrial", "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.", "http://dummyimage.com/178x100.png/ff4444/ffffff", "$4.45", 49, 8, "Maxim Integrated Products, Inc." },
                    { 13, "Grocery", "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", "http://dummyimage.com/166x100.png/5fa2dd/ffffff", "$5.52", 12, 1, "ZAGG Inc" },
                    { 14, "Outdoors", "Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", "http://dummyimage.com/136x100.png/dddddd/000000", "$0.30", 13, 7, "Champions Oncology, Inc." },
                    { 15, "Beauty", "Cras pellentesque volutpat dui.", "http://dummyimage.com/187x100.png/ff4444/ffffff", "$9.48", 43, 10, "EDAP TMS S.A." },
                    { 16, "Books", "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", "http://dummyimage.com/124x100.png/5fa2dd/ffffff", "$8.75", 12, 3, "Lennar Corporation" },
                    { 17, "Computers", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", "http://dummyimage.com/178x100.png/ff4444/ffffff", "$5.09", 50, 2, "Denbury Resources Inc." },
                    { 18, "Kids", "Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", "http://dummyimage.com/235x100.png/dddddd/000000", "$1.36", 20, 8, "American Eagle Outfitters, Inc." },
                    { 19, "Books", "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", "http://dummyimage.com/117x100.png/5fa2dd/ffffff", "$9.35", 7, 7, "Dun & Bradstreet Corporation (The)" },
                    { 20, "Home", "Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", "http://dummyimage.com/181x100.png/ff4444/ffffff", "$0.46", 41, 1, "Global X S&P 500 Catholic Values ETF" },
                    { 21, "Automotive", "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.", "http://dummyimage.com/159x100.png/5fa2dd/ffffff", "$1.64", 49, 9, "Telephone and Data Systems, Inc." },
                    { 22, "Jewelry", "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.", "http://dummyimage.com/142x100.png/5fa2dd/ffffff", "$7.25", 8, 3, "First Trust Low Beta Income ETF" },
                    { 23, "Industrial", "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", "http://dummyimage.com/116x100.png/dddddd/000000", "$3.05", 2, 3, "Dollar Tree, Inc." },
                    { 24, "Sports", "Integer ac neque.", "http://dummyimage.com/188x100.png/5fa2dd/ffffff", "$3.34", 5, 6, "Aspen Insurance Holdings Limited" },
                    { 25, "Automotive", "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", "http://dummyimage.com/184x100.png/ff4444/ffffff", "$6.78", 11, 6, "Fortress Investment Group LLC" },
                    { 26, "Movies", "Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.", "http://dummyimage.com/205x100.png/5fa2dd/ffffff", "$6.17", 14, 5, "Amyris, Inc." },
                    { 27, "Baby", "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", "http://dummyimage.com/242x100.png/cc0000/ffffff", "$5.40", 23, 6, "LMP Capital and Income Fund Inc." },
                    { 28, "Clothing", "Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", "http://dummyimage.com/221x100.png/cc0000/ffffff", "$6.27", 2, 1, "Calamos Global Dynamic Income Fund" },
                    { 29, "Shoes", "Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", "http://dummyimage.com/120x100.png/cc0000/ffffff", "$2.31", 47, 4, "Calgon Carbon Corporation" },
                    { 30, "Sports", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", "http://dummyimage.com/129x100.png/cc0000/ffffff", "$1.71", 12, 1, "Olympic Steel, Inc." },
                    { 31, "Shoes", "In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", "http://dummyimage.com/124x100.png/dddddd/000000", "$4.04", 41, 6, "Atlantic Capital Bancshares, Inc." },
                    { 32, "Beauty", "Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", "http://dummyimage.com/101x100.png/ff4444/ffffff", "$9.79", 49, 10, "Washington Prime Group Inc." },
                    { 33, "Health", "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", "http://dummyimage.com/128x100.png/cc0000/ffffff", "$6.68", 26, 8, "Lennar Corporation" },
                    { 34, "Kids", "Proin at turpis a pede posuere nonummy.", "http://dummyimage.com/246x100.png/5fa2dd/ffffff", "$6.83", 48, 10, "Antero Resources Corporation" },
                    { 35, "Toys", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend.", "http://dummyimage.com/249x100.png/cc0000/ffffff", "$8.27", 4, 3, "Federal Agricultural Mortgage Corporation" },
                    { 36, "Clothing", "Maecenas pulvinar lobortis est. Phasellus sit amet erat.", "http://dummyimage.com/232x100.png/cc0000/ffffff", "$4.41", 1, 4, "Check-Cap Ltd." },
                    { 37, "Kids", "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", "http://dummyimage.com/198x100.png/ff4444/ffffff", "$7.98", 43, 5, "Fresenius Medical Care Corporation" },
                    { 38, "Books", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", "http://dummyimage.com/179x100.png/5fa2dd/ffffff", "$1.90", 49, 9, "Ardelyx, Inc." },
                    { 39, "Health", "Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", "http://dummyimage.com/144x100.png/ff4444/ffffff", "$4.70", 35, 9, "Papa Murphy's Holdings, Inc." },
                    { 40, "Sports", "Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", "http://dummyimage.com/207x100.png/5fa2dd/ffffff", "$5.35", 26, 10, "First Trust Mid Cap Value AlphaDEX Fund" },
                    { 41, "Outdoors", "Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.", "http://dummyimage.com/131x100.png/ff4444/ffffff", "$4.96", 45, 10, "Chesapeake Energy Corporation" },
                    { 42, "Music", "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.", "http://dummyimage.com/170x100.png/dddddd/000000", "$5.08", 39, 10, "BlackRock California Municipal Income Trust" },
                    { 43, "Industrial", "Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", "http://dummyimage.com/189x100.png/dddddd/000000", "$6.23", 38, 7, "Frontier Communications Corporation" },
                    { 44, "Tools", "Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.", "http://dummyimage.com/165x100.png/dddddd/000000", "$5.48", 13, 9, "Akers Biosciences Inc" },
                    { 45, "Jewelry", "Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus.", "http://dummyimage.com/184x100.png/cc0000/ffffff", "$6.99", 27, 7, "Forest City Realty Trust, Inc." },
                    { 46, "Sports", "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.", "http://dummyimage.com/132x100.png/dddddd/000000", "$9.82", 46, 9, "Flotek Industries, Inc." },
                    { 47, "Books", "Donec ut mauris eget massa tempor convallis.", "http://dummyimage.com/146x100.png/dddddd/000000", "$0.93", 3, 5, "MiX Telematics Limited" },
                    { 48, "Movies", "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", "http://dummyimage.com/154x100.png/cc0000/ffffff", "$0.98", 6, 1, "Tuniu Corporation" },
                    { 49, "Industrial", "Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim.", "http://dummyimage.com/165x100.png/5fa2dd/ffffff", "$4.23", 50, 6, "Astrotech Corporation" },
                    { 50, "Jewelry", "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.", "http://dummyimage.com/177x100.png/5fa2dd/ffffff", "$4.04", 50, 1, "Total System Services, Inc." },
                    { 51, "Music", "Curabitur convallis.", "http://dummyimage.com/115x100.png/5fa2dd/ffffff", "$2.26", 28, 3, "Virtus Global Dividend & Income Fund Inc." },
                    { 52, "Beauty", "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", "http://dummyimage.com/249x100.png/cc0000/ffffff", "$8.47", 34, 4, "China New Borun Corporation" },
                    { 53, "Shoes", "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia.", "http://dummyimage.com/193x100.png/5fa2dd/ffffff", "$9.19", 1, 3, "Twenty-First Century Fox, Inc." },
                    { 54, "Clothing", "Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", "http://dummyimage.com/149x100.png/ff4444/ffffff", "$4.29", 42, 5, "Morgan Stanley Emerging Markets Domestic Debt Fund, Inc." },
                    { 55, "Toys", "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", "http://dummyimage.com/228x100.png/cc0000/ffffff", "$1.71", 22, 2, "Dimension Therapeutics, Inc." },
                    { 56, "Movies", "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam. Nam tristique tortor eu pede.", "http://dummyimage.com/249x100.png/dddddd/000000", "$6.94", 5, 5, "Lsb Industries Inc." },
                    { 57, "Computers", "Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.", "http://dummyimage.com/168x100.png/cc0000/ffffff", "$4.59", 47, 9, "Flowserve Corporation" },
                    { 58, "Outdoors", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.", "http://dummyimage.com/155x100.png/5fa2dd/ffffff", "$9.78", 40, 10, "Eagle Bancorp, Inc." },
                    { 59, "Computers", "Praesent blandit. Nam nulla.", "http://dummyimage.com/104x100.png/ff4444/ffffff", "$0.94", 48, 9, "General Mills, Inc." },
                    { 60, "Baby", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum.", "http://dummyimage.com/198x100.png/ff4444/ffffff", "$1.27", 33, 3, "BOK Financial Corporation" },
                    { 61, "Toys", "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", "http://dummyimage.com/104x100.png/dddddd/000000", "$0.50", 29, 6, "ABM Industries Incorporated" },
                    { 62, "Health", "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", "http://dummyimage.com/132x100.png/5fa2dd/ffffff", "$8.49", 25, 2, "iSectors Post-MPT Growth ETF" },
                    { 63, "Grocery", "Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.", "http://dummyimage.com/154x100.png/dddddd/000000", "$6.64", 23, 8, "NCI, Inc." },
                    { 64, "Electronics", "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "http://dummyimage.com/138x100.png/dddddd/000000", "$6.06", 8, 1, "IBERIABANK Corporation" },
                    { 65, "Clothing", "Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", "http://dummyimage.com/208x100.png/ff4444/ffffff", "$1.55", 32, 6, "Varian Medical Systems, Inc." },
                    { 66, "Games", "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia.", "http://dummyimage.com/185x100.png/cc0000/ffffff", "$7.33", 30, 4, "T-Mobile US, Inc." },
                    { 67, "Automotive", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", "http://dummyimage.com/156x100.png/cc0000/ffffff", "$5.88", 13, 5, "Global Medical REIT Inc." },
                    { 68, "Computers", "Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", "http://dummyimage.com/151x100.png/ff4444/ffffff", "$0.19", 24, 7, "Royal Bancshares of Pennsylvania, Inc." },
                    { 69, "Health", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", "http://dummyimage.com/188x100.png/cc0000/ffffff", "$2.42", 45, 8, "Avinger, Inc." },
                    { 70, "Health", "Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.", "http://dummyimage.com/190x100.png/5fa2dd/ffffff", "$6.30", 28, 2, "Permian Basin Royalty Trust" },
                    { 71, "Jewelry", "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.", "http://dummyimage.com/109x100.png/5fa2dd/ffffff", "$0.86", 49, 3, "CGI Group, Inc." },
                    { 72, "Outdoors", "Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", "http://dummyimage.com/240x100.png/dddddd/000000", "$6.03", 8, 3, "Histogenics Corporation" },
                    { 73, "Kids", "Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", "http://dummyimage.com/114x100.png/dddddd/000000", "$9.58", 9, 5, "News Corporation" },
                    { 74, "Home", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.", "http://dummyimage.com/117x100.png/5fa2dd/ffffff", "$0.61", 28, 2, "CNB Financial Corporation" },
                    { 75, "Health", "Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo.", "http://dummyimage.com/225x100.png/dddddd/000000", "$0.17", 28, 1, "Bank of Commerce Holdings (CA)" },
                    { 76, "Tools", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", "http://dummyimage.com/203x100.png/5fa2dd/ffffff", "$4.73", 2, 6, "Uni-Pixel, Inc." },
                    { 77, "Computers", "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", "http://dummyimage.com/108x100.png/dddddd/000000", "$8.58", 19, 10, "United Fire Group, Inc" },
                    { 78, "Books", "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.", "http://dummyimage.com/189x100.png/5fa2dd/ffffff", "$2.93", 34, 10, "INVESCO MORTGAGE CAPITAL INC" },
                    { 79, "Grocery", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.", "http://dummyimage.com/220x100.png/ff4444/ffffff", "$3.19", 36, 10, "Eagle Bancorp Montana, Inc." },
                    { 80, "Tools", "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.", "http://dummyimage.com/182x100.png/dddddd/000000", "$4.72", 39, 10, "Sabra Healthcare REIT, Inc." },
                    { 81, "Computers", "In hac habitasse platea dictumst.", "http://dummyimage.com/184x100.png/5fa2dd/ffffff", "$3.82", 15, 1, "Patrick Industries, Inc." },
                    { 82, "Games", "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.", "http://dummyimage.com/191x100.png/5fa2dd/ffffff", "$1.79", 16, 6, "Alpine Global Premier Properties Fund" },
                    { 83, "Games", "Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.", "http://dummyimage.com/240x100.png/dddddd/000000", "$9.31", 7, 2, "Schnitzer Steel Industries, Inc." },
                    { 84, "Automotive", "Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.", "http://dummyimage.com/217x100.png/dddddd/000000", "$8.92", 30, 4, "MedEquities Realty Trust, Inc." },
                    { 85, "Sports", "Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus.", "http://dummyimage.com/191x100.png/5fa2dd/ffffff", "$2.83", 9, 4, "VelocityShares VIX Medium-Term ETN" },
                    { 86, "Shoes", "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio.", "http://dummyimage.com/123x100.png/ff4444/ffffff", "$0.79", 38, 9, "Willamette Valley Vineyards, Inc." },
                    { 87, "Games", "Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", "http://dummyimage.com/120x100.png/cc0000/ffffff", "$3.53", 29, 7, "Northeast Bancorp" },
                    { 88, "Games", "Nunc rhoncus dui vel sem. Sed sagittis.", "http://dummyimage.com/214x100.png/5fa2dd/ffffff", "$0.89", 22, 10, "SigmaTron International, Inc." },
                    { 89, "Games", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.", "http://dummyimage.com/150x100.png/ff4444/ffffff", "$0.97", 50, 9, "Catasys, Inc." },
                    { 90, "Music", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", "http://dummyimage.com/213x100.png/5fa2dd/ffffff", "$5.87", 8, 5, "Cummins Inc." },
                    { 91, "Grocery", "Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.", "http://dummyimage.com/116x100.png/ff4444/ffffff", "$2.73", 16, 10, "Tech Data Corporation" },
                    { 92, "Grocery", "Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", "http://dummyimage.com/174x100.png/cc0000/ffffff", "$6.54", 26, 7, "Rite Aid Corporation" },
                    { 93, "Garden", "Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.", "http://dummyimage.com/246x100.png/cc0000/ffffff", "$5.30", 49, 5, "Boston Private Financial Holdings, Inc." },
                    { 94, "Home", "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.", "http://dummyimage.com/246x100.png/ff4444/ffffff", "$8.95", 5, 4, "Arbor Realty Trust" },
                    { 95, "Home", "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", "http://dummyimage.com/169x100.png/ff4444/ffffff", "$2.03", 18, 3, "Putnam High Income Bond Fund" },
                    { 96, "Kids", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus.", "http://dummyimage.com/152x100.png/dddddd/000000", "$5.84", 31, 9, "PowerShares DWA Momentum Portfolio" },
                    { 97, "Industrial", "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", "http://dummyimage.com/168x100.png/5fa2dd/ffffff", "$0.26", 24, 1, "Anworth Mortgage Asset  Corporation" },
                    { 98, "Clothing", "Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum.", "http://dummyimage.com/113x100.png/5fa2dd/ffffff", "$0.93", 26, 7, "Farmer Brothers Company" },
                    { 99, "Outdoors", "Donec ut dolor.", "http://dummyimage.com/237x100.png/cc0000/ffffff", "$5.86", 16, 5, "Colony NorthStar, Inc." },
                    { 100, "Industrial", "Integer ac leo. Pellentesque ultrices mattis odio.", "http://dummyimage.com/205x100.png/5fa2dd/ffffff", "$2.11", 43, 7, "America Movil, S.A.B. de C.V." },
                    { 101, "Grocery", "Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.", "http://dummyimage.com/124x100.png/dddddd/000000", "$1.48", 7, 1, "2U, Inc." },
                    { 102, "Shoes", "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.", "http://dummyimage.com/199x100.png/dddddd/000000", "$5.45", 20, 8, "Aldeyra Therapeutics, Inc." },
                    { 103, "Health", "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", "http://dummyimage.com/130x100.png/dddddd/000000", "$2.90", 50, 7, "Honeywell International Inc." },
                    { 104, "Toys", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", "http://dummyimage.com/125x100.png/cc0000/ffffff", "$3.49", 18, 9, "Isramco, Inc." },
                    { 105, "Industrial", "Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", "http://dummyimage.com/146x100.png/5fa2dd/ffffff", "$5.37", 9, 8, "Aquinox Pharmaceuticals, Inc." },
                    { 106, "Computers", "In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit.", "http://dummyimage.com/181x100.png/5fa2dd/ffffff", "$9.49", 24, 6, "WMIH Corp." },
                    { 107, "Clothing", "Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.", "http://dummyimage.com/208x100.png/cc0000/ffffff", "$5.94", 30, 6, "Parsley Energy, Inc." },
                    { 108, "Grocery", "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", "http://dummyimage.com/108x100.png/ff4444/ffffff", "$9.59", 40, 10, "Kelly Services, Inc." },
                    { 109, "Shoes", "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.", "http://dummyimage.com/229x100.png/cc0000/ffffff", "$6.51", 35, 9, "DineEquity, Inc" },
                    { 110, "Baby", "Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.", "http://dummyimage.com/181x100.png/cc0000/ffffff", "$0.50", 18, 3, "Reinsurance Group of America, Incorporated" },
                    { 111, "Garden", "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", "http://dummyimage.com/239x100.png/dddddd/000000", "$8.50", 45, 4, "Opus Bank" },
                    { 112, "Garden", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.", "http://dummyimage.com/113x100.png/5fa2dd/ffffff", "$6.90", 2, 1, "Apollo Investment Corporation" },
                    { 113, "Jewelry", "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue.", "http://dummyimage.com/114x100.png/dddddd/000000", "$2.95", 33, 6, "Lazard World Dividend & Income Fund, Inc." },
                    { 114, "Home", "Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia.", "http://dummyimage.com/151x100.png/cc0000/ffffff", "$7.66", 42, 3, "Varonis Systems, Inc." },
                    { 115, "Health", "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", "http://dummyimage.com/233x100.png/dddddd/000000", "$2.00", 43, 9, "Aspen Insurance Holdings Limited" },
                    { 116, "Kids", "Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.", "http://dummyimage.com/118x100.png/5fa2dd/ffffff", "$9.58", 41, 1, "OceanFirst Financial Corp." },
                    { 117, "Garden", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", "http://dummyimage.com/166x100.png/ff4444/ffffff", "$0.71", 37, 10, "Pure Cycle Corporation" },
                    { 118, "Electronics", "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", "http://dummyimage.com/114x100.png/5fa2dd/ffffff", "$1.24", 1, 3, "Hortonworks, Inc." },
                    { 119, "Computers", "Nullam molestie nibh in lectus.", "http://dummyimage.com/156x100.png/ff4444/ffffff", "$1.51", 40, 7, "U.S. Bancorp" },
                    { 120, "Electronics", "Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", "http://dummyimage.com/132x100.png/cc0000/ffffff", "$3.49", 22, 1, "Lifevantage Corporation" },
                    { 121, "Baby", "In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", "http://dummyimage.com/244x100.png/5fa2dd/ffffff", "$2.57", 4, 6, "Cyclacel Pharmaceuticals, Inc." },
                    { 122, "Kids", "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", "http://dummyimage.com/214x100.png/dddddd/000000", "$9.75", 15, 1, "LeMaitre Vascular, Inc." },
                    { 123, "Electronics", "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "http://dummyimage.com/134x100.png/cc0000/ffffff", "$5.04", 23, 6, "Perceptron, Inc." },
                    { 124, "Computers", "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat.", "http://dummyimage.com/188x100.png/ff4444/ffffff", "$7.23", 29, 5, "Atlas Air Worldwide Holdings" },
                    { 125, "Music", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.", "http://dummyimage.com/217x100.png/dddddd/000000", "$0.98", 24, 2, "Wheeler Real Estate Investment Trust, Inc." },
                    { 126, "Baby", "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", "http://dummyimage.com/111x100.png/5fa2dd/ffffff", "$1.27", 40, 2, "Conn's, Inc." },
                    { 127, "Home", "Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam. Nam tristique tortor eu pede.", "http://dummyimage.com/102x100.png/ff4444/ffffff", "$1.91", 21, 7, "Formula Systems (1985) Ltd." },
                    { 128, "Computers", "Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", "http://dummyimage.com/179x100.png/ff4444/ffffff", "$9.75", 24, 9, "Dominion Diamond Corporation" },
                    { 129, "Computers", "In congue. Etiam justo.", "http://dummyimage.com/247x100.png/cc0000/ffffff", "$5.78", 11, 3, "Accuray Incorporated" },
                    { 130, "Sports", "Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", "http://dummyimage.com/223x100.png/cc0000/ffffff", "$2.24", 20, 3, "Earthstone Energy, Inc." },
                    { 131, "Music", "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue.", "http://dummyimage.com/102x100.png/dddddd/000000", "$1.35", 47, 2, "Nasdaq, Inc." },
                    { 132, "Grocery", "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.", "http://dummyimage.com/106x100.png/cc0000/ffffff", "$9.45", 2, 6, "Selective Insurance Group, Inc." },
                    { 133, "Books", "Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.", "http://dummyimage.com/211x100.png/ff4444/ffffff", "$5.44", 6, 9, "Braskem S.A." },
                    { 134, "Baby", "Morbi a ipsum.", "http://dummyimage.com/157x100.png/dddddd/000000", "$3.10", 10, 5, "Carbo Ceramics, Inc." },
                    { 135, "Music", "Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices.", "http://dummyimage.com/199x100.png/ff4444/ffffff", "$1.36", 49, 2, "Cardiome Pharma Corporation" },
                    { 136, "Garden", "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", "http://dummyimage.com/150x100.png/dddddd/000000", "$3.51", 31, 9, "iShares MSCI EM ESG Optimized ETF" },
                    { 137, "Garden", "Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.", "http://dummyimage.com/218x100.png/5fa2dd/ffffff", "$2.24", 21, 7, "WisdomTree United Kingdom Hedged Equity Fund" },
                    { 138, "Shoes", "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", "http://dummyimage.com/122x100.png/cc0000/ffffff", "$5.92", 19, 3, "Tyson Foods, Inc." },
                    { 139, "Movies", "Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "http://dummyimage.com/233x100.png/dddddd/000000", "$4.08", 37, 9, "Telephone and Data Systems, Inc." },
                    { 140, "Garden", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.", "http://dummyimage.com/131x100.png/dddddd/000000", "$7.06", 27, 4, "I.D. Systems, Inc." },
                    { 141, "Books", "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", "http://dummyimage.com/206x100.png/cc0000/ffffff", "$6.55", 45, 2, "Innovative Solutions and Support, Inc." },
                    { 142, "Kids", "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis.", "http://dummyimage.com/202x100.png/dddddd/000000", "$9.32", 29, 8, "Provident Financial Holdings, Inc." },
                    { 143, "Sports", "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", "http://dummyimage.com/219x100.png/dddddd/000000", "$7.74", 13, 6, "Alliance HealthCare Services, Inc." },
                    { 144, "Tools", "Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.", "http://dummyimage.com/118x100.png/dddddd/000000", "$7.97", 5, 5, "BlackRock New York Investment Quality Municipal Trust Inc. (Th" },
                    { 145, "Tools", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.", "http://dummyimage.com/204x100.png/5fa2dd/ffffff", "$8.05", 50, 4, "Bank of the Ozarks" },
                    { 146, "Jewelry", "Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", "http://dummyimage.com/191x100.png/ff4444/ffffff", "$2.72", 42, 4, "Calamos Strategic Total Return Fund" },
                    { 147, "Health", "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "http://dummyimage.com/170x100.png/cc0000/ffffff", "$4.57", 17, 3, "Wheaton Precious Metals Corp." },
                    { 148, "Baby", "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", "http://dummyimage.com/105x100.png/cc0000/ffffff", "$0.37", 47, 9, "Chesapeake Utilities Corporation" },
                    { 149, "Computers", "Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", "http://dummyimage.com/244x100.png/5fa2dd/ffffff", "$4.12", 31, 3, "Seagate Technology PLC" },
                    { 150, "Electronics", "Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", "http://dummyimage.com/119x100.png/dddddd/000000", "$1.77", 50, 4, "Mechel PAO" },
                    { 151, "Tools", "Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", "http://dummyimage.com/214x100.png/ff4444/ffffff", "$8.35", 27, 4, "Customers Bancorp, Inc" },
                    { 152, "Music", "Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", "http://dummyimage.com/162x100.png/ff4444/ffffff", "$7.15", 20, 8, "Bank of America Corporation" },
                    { 153, "Automotive", "Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.", "http://dummyimage.com/180x100.png/cc0000/ffffff", "$6.94", 6, 7, "Intercontinental Exchange Inc." },
                    { 154, "Grocery", "Ut at dolor quis odio consequat varius.", "http://dummyimage.com/102x100.png/cc0000/ffffff", "$8.46", 47, 10, "Ultrapar Participacoes S.A." },
                    { 155, "Movies", "Nunc rhoncus dui vel sem.", "http://dummyimage.com/113x100.png/cc0000/ffffff", "$1.51", 16, 7, "Sabre Corporation" },
                    { 156, "Movies", "Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", "http://dummyimage.com/158x100.png/ff4444/ffffff", "$8.51", 33, 10, "Mechel PAO" },
                    { 157, "Computers", "Nunc nisl.", "http://dummyimage.com/231x100.png/cc0000/ffffff", "$4.89", 37, 4, "Vantage Energy Acquisition Corp." },
                    { 158, "Baby", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", "http://dummyimage.com/242x100.png/dddddd/000000", "$1.29", 22, 3, "The Meet Group, Inc." },
                    { 159, "Baby", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.", "http://dummyimage.com/152x100.png/ff4444/ffffff", "$6.79", 15, 8, "WisdomTree Western Asset Unconstrained Bond Fund" },
                    { 160, "Electronics", "Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", "http://dummyimage.com/228x100.png/dddddd/000000", "$0.21", 47, 8, "Flagstar Bancorp, Inc." },
                    { 161, "Games", "Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.", "http://dummyimage.com/159x100.png/cc0000/ffffff", "$5.93", 1, 6, "Oncobiologics, Inc." },
                    { 162, "Games", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", "http://dummyimage.com/190x100.png/dddddd/000000", "$5.91", 3, 1, "Robert Half International Inc." },
                    { 163, "Music", "Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", "http://dummyimage.com/108x100.png/cc0000/ffffff", "$9.93", 16, 9, "Sonic Automotive, Inc." },
                    { 164, "Industrial", "Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", "http://dummyimage.com/217x100.png/dddddd/000000", "$7.08", 38, 8, "Raymond James Financial, Inc." },
                    { 165, "Kids", "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", "http://dummyimage.com/236x100.png/cc0000/ffffff", "$2.99", 25, 6, "Farmland Partners Inc." },
                    { 166, "Clothing", "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt.", "http://dummyimage.com/229x100.png/5fa2dd/ffffff", "$7.98", 29, 6, "Invesco Value Municipal Income Trust" },
                    { 167, "Books", "Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.", "http://dummyimage.com/106x100.png/ff4444/ffffff", "$6.23", 18, 5, "Myovant Sciences Ltd." },
                    { 168, "Grocery", "Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", "http://dummyimage.com/223x100.png/ff4444/ffffff", "$8.71", 42, 8, "Global Blood Therapeutics, Inc." },
                    { 169, "Sports", "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", "http://dummyimage.com/165x100.png/cc0000/ffffff", "$4.93", 40, 6, "Special Opportunities Fund Inc." },
                    { 170, "Music", "Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.", "http://dummyimage.com/248x100.png/cc0000/ffffff", "$0.81", 30, 10, "Active Alts Contrarian ETF" },
                    { 171, "Industrial", "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis.", "http://dummyimage.com/120x100.png/5fa2dd/ffffff", "$6.46", 10, 1, "Albany Molecular Research, Inc." },
                    { 172, "Toys", "Morbi vel lectus in quam fringilla rhoncus.", "http://dummyimage.com/110x100.png/cc0000/ffffff", "$6.88", 30, 4, "Cerus Corporation" },
                    { 173, "Health", "Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend.", "http://dummyimage.com/204x100.png/dddddd/000000", "$2.13", 40, 2, "Wells Fargo & Company" },
                    { 174, "Computers", "Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", "http://dummyimage.com/144x100.png/5fa2dd/ffffff", "$2.89", 12, 8, "WideOpenWest, Inc." },
                    { 175, "Books", "Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", "http://dummyimage.com/244x100.png/cc0000/ffffff", "$4.39", 4, 8, "Ardelyx, Inc." },
                    { 176, "Beauty", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", "http://dummyimage.com/217x100.png/cc0000/ffffff", "$1.64", 12, 6, "Turkish Investment Fund, Inc. (The)" },
                    { 177, "Electronics", "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.", "http://dummyimage.com/195x100.png/5fa2dd/ffffff", "$3.94", 35, 3, "Kingstone Companies, Inc" },
                    { 178, "Music", "Proin eu mi. Nulla ac enim.", "http://dummyimage.com/140x100.png/cc0000/ffffff", "$4.67", 18, 6, "Westlake Chemical Partners LP" },
                    { 179, "Music", "Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", "http://dummyimage.com/118x100.png/cc0000/ffffff", "$3.01", 23, 8, "Corporate Office Properties Trust" },
                    { 180, "Kids", "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", "http://dummyimage.com/118x100.png/5fa2dd/ffffff", "$2.44", 22, 7, "Endeavour Silver Corporation" },
                    { 181, "Outdoors", "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.", "http://dummyimage.com/100x100.png/dddddd/000000", "$9.41", 21, 8, "Bank Of New York Mellon Corporation (The)" },
                    { 182, "Computers", "Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", "http://dummyimage.com/193x100.png/ff4444/ffffff", "$6.24", 38, 6, "Agios Pharmaceuticals, Inc." },
                    { 183, "Garden", "Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum.", "http://dummyimage.com/146x100.png/dddddd/000000", "$3.98", 3, 4, "Elbit Systems Ltd." },
                    { 184, "Movies", "Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.", "http://dummyimage.com/201x100.png/ff4444/ffffff", "$7.40", 2, 4, "Qwest Corporation" },
                    { 185, "Books", "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", "http://dummyimage.com/247x100.png/cc0000/ffffff", "$4.36", 40, 4, "SigmaTron International, Inc." },
                    { 186, "Games", "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.", "http://dummyimage.com/154x100.png/dddddd/000000", "$5.79", 40, 7, "Gaming and Leisure Properties, Inc." },
                    { 187, "Beauty", "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.", "http://dummyimage.com/116x100.png/dddddd/000000", "$5.58", 25, 4, "Delta Technology Holdings Limited" },
                    { 188, "Games", "Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.", "http://dummyimage.com/158x100.png/cc0000/ffffff", "$0.79", 9, 2, "First Trust Mid Cap Growth AlphaDEX Fund" },
                    { 189, "Automotive", "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque.", "http://dummyimage.com/100x100.png/ff4444/ffffff", "$1.17", 21, 9, "Natl Westminster Pfd" },
                    { 190, "Computers", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis.", "http://dummyimage.com/246x100.png/cc0000/ffffff", "$5.69", 17, 4, "PS Business Parks, Inc." },
                    { 191, "Toys", "Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.", "http://dummyimage.com/230x100.png/ff4444/ffffff", "$7.53", 47, 7, "DCP Midstream LP" },
                    { 192, "Electronics", "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", "http://dummyimage.com/116x100.png/ff4444/ffffff", "$4.85", 1, 8, "Chatham Lodging Trust (REIT)" },
                    { 193, "Books", "Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.", "http://dummyimage.com/210x100.png/ff4444/ffffff", "$2.87", 29, 6, "Western Asset/Claymore U.S Treasury Inflation Prot Secs Fd 2" },
                    { 194, "Books", "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo.", "http://dummyimage.com/230x100.png/cc0000/ffffff", "$4.45", 47, 1, "Tredegar Corporation" },
                    { 195, "Automotive", "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum.", "http://dummyimage.com/100x100.png/5fa2dd/ffffff", "$7.82", 10, 10, "Davis Select U.S. Equity ETF" },
                    { 196, "Clothing", "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "http://dummyimage.com/207x100.png/dddddd/000000", "$5.85", 44, 3, "Emmis Communications Corporation" },
                    { 197, "Shoes", "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.", "http://dummyimage.com/172x100.png/cc0000/ffffff", "$6.53", 4, 8, "Eaton Vance Senior Floating-Rate Fund" },
                    { 198, "Sports", "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", "http://dummyimage.com/113x100.png/ff4444/ffffff", "$9.80", 34, 8, "Hope Bancorp, Inc." },
                    { 199, "Beauty", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", "http://dummyimage.com/201x100.png/5fa2dd/ffffff", "$5.84", 34, 1, "M.D.C. Holdings, Inc." },
                    { 200, "Kids", "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.", "http://dummyimage.com/152x100.png/5fa2dd/ffffff", "$8.63", 14, 10, "Templeton Emerging Markets Income Fund, Inc." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "StoreId" },
                values: new object[,]
                {
                    { 1, "wbampfield0@vinaora.com", "IXoPdcjvPF4Y", "user", 4 },
                    { 2, "eargyle1@discovery.com", "zSwyT8GV1", "user", 7 },
                    { 3, "bcroisier2@tinyurl.com", "MmRfw9Xqu", "user", 6 },
                    { 4, "qvasichev3@elegantthemes.com", "BWV8qNBX", "user", 9 },
                    { 5, "zabad4@github.io", "rN4et5", "user", 4 },
                    { 6, "cmcgahy5@archive.org", "7msf26U41g", "user", 7 },
                    { 7, "cjurczyk6@theatlantic.com", "xxnBq4wz", "admin", 2 },
                    { 8, "tpristnor7@51.la", "bGv9dJV", "user", 5 },
                    { 9, "plente8@disqus.com", "gs5faw", "user", 7 },
                    { 10, "mzanuciolii9@sbwire.com", "f4ydwc", "admin", 1 },
                    { 11, "rservanta@ovh.net", "ZtPT4ve9KKnX", "user", 2 },
                    { 12, "fwiddopb@rambler.ru", "fJ6w4emm", "admin", 10 },
                    { 13, "agommesc@hp.com", "ok4Qx45", "admin", 6 },
                    { 14, "tclarycottd@redcross.org", "5rMu2pflm7", "user", 10 },
                    { 15, "fmcmorlande@bigcartel.com", "KkyWzHZpeX", "user", 9 },
                    { 16, "owaudbyf@myspace.com", "VnOIoyqT", "user", 9 },
                    { 17, "dkarpfg@discovery.com", "InqXQx5", "user", 4 },
                    { 18, "atemprellh@discuz.net", "YYLBGf", "admin", 1 },
                    { 19, "hdominiquei@ft.com", "lVGdOfga", "super-admin", 5 },
                    { 20, "dgeerj@jigsy.com", "KLwp84TFQIY", "user", 9 },
                    { 21, "layrsk@odnoklassniki.ru", "LgdFvCYoU", "super-admin", 6 },
                    { 22, "mbraunsteinl@amazon.co.uk", "V3HAd2ASh", "user", 7 },
                    { 23, "tdictem@mapy.cz", "goND1pToI", "user", 7 },
                    { 24, "mavisonn@senate.gov", "USZoqlrTU", "user", 6 },
                    { 25, "mhicko@reddit.com", "wtpjLP", "user", 10 },
                    { 26, "wredanp@biblegateway.com", "85Ql28L", "user", 5 },
                    { 27, "tnodeq@jalbum.net", "DEpw7m", "admin", 3 },
                    { 28, "dmattysr@1und1.de", "cXOdCB", "user", 5 },
                    { 29, "tstrauns@amazon.co.jp", "vm2d9UHUC", "super-admin", 7 },
                    { 30, "pclevelandt@seesaa.net", "AmPaV6ZSS", "user", 3 },
                    { 31, "nmorebyu@buzzfeed.com", "z32ARkg1", "user", 9 },
                    { 32, "mcheneyv@icq.com", "Axsw61", "admin", 9 },
                    { 33, "fkilleleyw@home.pl", "f9zaiG", "admin", 1 },
                    { 34, "mseifenmacherx@wp.com", "EQugdt7P", "user", 1 },
                    { 35, "igaythwaitey@arizona.edu", "7LypXILcmks", "admin", 7 },
                    { 36, "lpulhosterz@taobao.com", "8QRc71pv", "user", 5 },
                    { 37, "bboribal10@tripadvisor.com", "O5ySj4DlN", "user", 7 },
                    { 38, "kprickett11@army.mil", "0dT70fBkvT6", "user", 8 },
                    { 39, "achasmar12@columbia.edu", "ZNcJinrbp", "user", 9 },
                    { 40, "hknapper13@pen.io", "DY7XXh3", "user", 7 },
                    { 41, "klazarus14@nyu.edu", "5Oa9PK8DRv", "admin", 7 },
                    { 42, "eshimman15@google.ru", "Bt8DmMtjJPiX", "user", 10 },
                    { 43, "klandreth16@xinhuanet.com", "bTVLrRT8", "admin", 2 },
                    { 44, "mnoor17@utexas.edu", "o6SCV1wwd", "user", 1 },
                    { 45, "bsulter18@princeton.edu", "61fvCWzSWU", "user", 3 },
                    { 46, "bbrundale19@go.com", "2IABIDDCzZfH", "user", 4 },
                    { 47, "arefford1a@1688.com", "bc7h7I", "user", 5 },
                    { 48, "hhasser1b@uol.com.br", "9OOdzv4X", "user", 1 },
                    { 49, "dharbard1c@opensource.org", "11q8p5gLV", "user", 6 },
                    { 50, "kdorosario1d@dot.gov", "zhNC9gyF", "admin", 5 },
                    { 51, "lcollacombe1e@studiopress.com", "Hml1fc2cX", "admin", 10 },
                    { 52, "rwalsh1f@woothemes.com", "eHdOHH8VX4", "admin", 9 },
                    { 53, "rdolan1g@berkeley.edu", "5vr1PJBo", "admin", 10 },
                    { 54, "jsteer1h@feedburner.com", "mX45Zj99", "admin", 8 },
                    { 55, "jknappe1i@army.mil", "JyPOdctMV", "user", 5 },
                    { 56, "epolamontayne1j@epa.gov", "T2fI2bl1", "admin", 5 },
                    { 57, "asimkin1k@taobao.com", "aNyF5oaGJ", "user", 7 },
                    { 58, "mryal1l@hibu.com", "DFElLICoRr", "admin", 4 },
                    { 59, "bvedstra1m@nhs.uk", "fnt1slPpE9r8", "user", 6 },
                    { 60, "sgerin1n@wikispaces.com", "W7FHTm2JJXh", "user", 5 },
                    { 61, "nfoggarty1o@ft.com", "3hk8uly48B02", "admin", 4 },
                    { 62, "pbenardette1p@amazon.com", "kYjpwm", "user", 1 },
                    { 63, "zroscam1q@youtube.com", "KiJUyH", "user", 8 },
                    { 64, "lskitteral1r@virginia.edu", "pusSEaaaw4", "admin", 6 },
                    { 65, "lweddeburnscrimgeour1s@usa.gov", "U9UCI6W", "user", 7 },
                    { 66, "nasplin1t@admin.ch", "krY7gwF", "admin", 10 },
                    { 67, "lvotier1u@archive.org", "tT2XYTRGv", "user", 2 },
                    { 68, "crichard1v@bbb.org", "djqsQmxkO", "user", 3 },
                    { 69, "ddanford1w@ameblo.jp", "5LxU1YJpGK6", "user", 9 },
                    { 70, "thachard1x@dailymail.co.uk", "yvQarEIVF5S", "admin", 1 },
                    { 71, "creck1y@archive.org", "fVgWMETW", "super-admin", 3 },
                    { 72, "rlodge1z@unblog.fr", "x5io632", "user", 5 },
                    { 73, "mmcnae20@indiatimes.com", "feRjOfCyKI", "admin", 8 },
                    { 74, "mbrettle21@netvibes.com", "Xy8FHljHm", "user", 3 },
                    { 75, "vbuller22@vimeo.com", "S7WUQgYL2JLu", "admin", 5 },
                    { 76, "ebrecon23@irs.gov", "jsuMdK", "super-admin", 7 },
                    { 77, "asokale24@bluehost.com", "kfJsGtdhU", "user", 8 },
                    { 78, "dbuttrum25@constantcontact.com", "4JDMGHlXQ2", "user", 5 },
                    { 79, "sloving26@tripod.com", "kLrciA0", "user", 10 },
                    { 80, "phowsego27@goo.gl", "enG8usp", "super-admin", 7 },
                    { 81, "ujosilevich28@google.com.br", "7SXaKuxSl", "user", 4 },
                    { 82, "acramp29@1688.com", "Jhmpgd6touat", "user", 5 },
                    { 83, "cbanfill2a@usa.gov", "SjcFOzWR", "user", 9 },
                    { 84, "lendrizzi2b@tamu.edu", "4ywpYY", "user", 4 },
                    { 85, "hnisen2c@networkadvertising.org", "W4x9kL", "user", 2 },
                    { 86, "edonnan2d@tiny.cc", "n1uTpYT9Wv", "admin", 7 },
                    { 87, "kbrinkman2e@spiegel.de", "Sjnx0Thy1hiw", "user", 1 },
                    { 88, "edudman2f@shinystat.com", "taK1sDh7", "super-admin", 9 },
                    { 89, "bdixcey2g@163.com", "2sUy6HeUCZt", "admin", 1 },
                    { 90, "dsubhan2h@shop-pro.jp", "xaqQgPRBm", "user", 8 },
                    { 91, "mpellew2i@marriott.com", "0PqMdFSMDT", "user", 4 },
                    { 92, "jtuson2j@mashable.com", "kfj6Y31", "user", 3 },
                    { 93, "jtamblyn2k@opera.com", "7o41t8EL", "user", 8 },
                    { 94, "croskams2l@163.com", "iPxswpP", "user", 5 },
                    { 95, "kvallentin2m@seattletimes.com", "MtzJ3XAxa", "user", 4 },
                    { 96, "bchingedehals2n@delicious.com", "VSFxCG", "user", 2 },
                    { 97, "lblackwood2o@sakura.ne.jp", "je3Z0T7rAY", "user", 8 },
                    { 98, "ehodjetts2p@behance.net", "czJmJQ2NQknW", "user", 5 },
                    { 99, "rkayzer2q@diigo.com", "lLynRur3", "user", 6 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "StoreId" },
                values: new object[] { 100, "xchippendale2r@wired.com", "QlsbLyx8yBTD", "user", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "UniqueStoreId",
                keyValue: 10);
        }
    }
}
