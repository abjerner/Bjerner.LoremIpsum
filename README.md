Bjerner.LoremIpsum
==================

Based on the lorem ipsum generator from http://baconipsum.com/, this generator will create texts with various flavours. Current flavours are:

- Lorem ipsum (default)
- Bacon
- Cupcake
- Umbraco

#### Code Examples ####

##### Lorem ipsum #####

Generate five paragraphs with the default "Lorem ipsum..." flavour:

```C#
LoremIpsumGenerator generator = new LoremIpsumGenerator();

foreach (string str in generator.MakeParagraphs()) {
    Console.WriteLine(str);
    Console.WriteLine();
}
```

##### Bacon #####

Generate five paragraphs with "Bacon ipsum..." flavour:

```C#
LoremIpsumGenerator generator = new LoremIpsumGenerator(new BaconProvider());

foreach (string str in generator.MakeParagraphs()) {
    Console.WriteLine(str);
    Console.WriteLine();
}
```

##### Cupcake #####

Generate five paragraphs with "Cupcake ipsum..." flavour:

```C#
LoremIpsumGenerator generator = new LoremIpsumGenerator(new CupCakeProvider());

foreach (string str in generator.MakeParagraphs()) {
    Console.WriteLine(str);
    Console.WriteLine();
}
```

##### Umbraco #####

Generate five paragraphs with "Umbraco ipsum..." flavour:

```C#
LoremIpsumGenerator generator = new LoremIpsumGenerator(new UmbracoProvider());

foreach (string str in generator.MakeParagraphs()) {
    Console.WriteLine(str);
    Console.WriteLine();
}
```