// See https://aka.ms/new-console-template for more information
using System;
using ExtensionMethods;

Console.WriteLine("Extension Methods");

//A system method
List<int> numbers = new List<int>() { 34, 3, 67, 5, 11, 2 };
Console.WriteLine(numbers.Max());

//A new custom extended method for string
string post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Pretium vulputate sapien nec sagittis. Ornare quam viverra orci sagittis eu. Turpis egestas sed tempus urna et pharetra. Duis at tellus at urna condimentum mattis. Elementum eu facilisis sed odio morbi quis. In fermentum posuere urna nec tincidunt praesent semper feugiat nibh. Quis blandit turpis cursus in hac habitasse platea dictumst quisque. Laoreet id donec ultrices tincidunt arcu non sodales. Hac habitasse platea dictumst quisque sagittis purus sit amet. Vitae sapien pellentesque habitant morbi. Posuere ac ut consequat semper viverra nam. Egestas diam in arcu cursus euismod quis viverra nibh.\n\nBlandit aliquam etiam erat velit scelerisque in dictum non. Blandit libero volutpat sed cras. Tellus molestie nunc non blandit massa enim. Enim ut sem viverra aliquet eget. Quis hendrerit dolor magna eget. Ultrices eros in cursus turpis massa tincidunt dui. Pharetra magna ac placerat vestibulum. Adipiscing commodo elit at imperdiet dui. Quis eleifend quam adipiscing vitae. Lobortis mattis aliquam faucibus purus in massa tempor nec. A diam sollicitudin tempor id. Aliquet sagittis id consectetur purus ut faucibus pulvinar. Ultrices tincidunt arcu non sodales neque sodales ut etiam. Felis eget nunc lobortis mattis. Gravida arcu ac tortor dignissim convallis aenean et. In tellus integer feugiat scelerisque varius morbi.\n\nMollis aliquam ut porttitor leo a diam sollicitudin tempor id. Aenean sed adipiscing diam donec adipiscing tristique. Nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi. Elementum nisi quis eleifend quam adipiscing vitae. Purus in mollis nunc sed id semper risus in hendrerit. Vulputate ut pharetra sit amet aliquam id diam. Egestas diam in arcu cursus euismod. Diam ut venenatis tellus in metus vulputate. Habitant morbi tristique senectus et netus et. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Neque convallis a cras semper auctor neque vitae tempus. Donec ac odio tempor orci dapibus ultrices in.\n\nFaucibus turpis in eu mi bibendum neque. Enim nunc faucibus a pellentesque sit amet porttitor eget. Vitae sapien pellentesque habitant morbi. Mauris a diam maecenas sed enim ut sem. Odio eu feugiat pretium nibh. Gravida in fermentum et sollicitudin ac. Adipiscing bibendum est ultricies integer quis auctor elit. Sit amet venenatis urna cursus eget nunc scelerisque viverra. Enim nulla aliquet porttitor lacus luctus accumsan tortor. Vel pharetra vel turpis nunc eget lorem dolor sed viverra. Viverra vitae congue eu consequat ac felis donec et odio. Mus mauris vitae ultricies leo integer malesuada nunc vel. In ante metus dictum at tempor commodo ullamcorper a lacus. Venenatis urna cursus eget nunc scelerisque viverra mauris in. Ac ut consequat semper viverra. Felis donec et odio pellentesque diam volutpat. Netus et malesuada fames ac turpis egestas integer. Elit ullamcorper dignissim cras tincidunt. Aliquam faucibus purus in massa tempor nec. Tincidunt arcu non sodales neque.\n\nEgestas integer eget aliquet nibh. Ultrices vitae auctor eu augue ut. Lectus vestibulum mattis ullamcorper velit. Sed turpis tincidunt id aliquet risus feugiat. Viverra ipsum nunc aliquet bibendum enim facilisis gravida neque convallis. Nunc lobortis mattis aliquam faucibus purus in massa tempor. Viverra justo nec ultrices dui. Nunc mattis enim ut tellus elementum sagittis. Vulputate enim nulla aliquet porttitor lacus. Eu lobortis elementum nibh tellus molestie nunc non blandit. Parturient montes nascetur ridiculus mus mauris vitae ultricies leo.";
Console.WriteLine(post.Shorten(5));

//A new custom extended method for MyClass
MyClass myClass = new MyClass();
myClass.IntProperty = 1;
myClass.StringProperty = "Hello";
myClass.DateTimeProperty = DateTime.Now;
Console.WriteLine(myClass.PrintMyClass(","));
Console.WriteLine(myClass.PrintJSON());


