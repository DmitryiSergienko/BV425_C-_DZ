using BV425_C__DZ.Classes;

var strings =
    """
        sub main
    
        set a 1
        call foo
        print a


        sub foo
        set a 2
    """;

var interpretator = new Content(strings);

interpretator.Show();