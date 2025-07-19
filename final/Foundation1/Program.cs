using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1a = new Comment();
        comment1a._name = "Diosa";
        comment1a._text = "I wanna go there too!";

        Comment comment1b = new Comment();
        comment1b._name = "Andrei";
        comment1b._text = "Looks fun!";

        Comment comment1c = new Comment();
        comment1c._name = "Andrus";
        comment1c._text = "My mom lived there for a while and she can't wait to take us there too.";

        Video video1 = new Video();
        video1._title = "Why I love Melbourne";
        video1._author = "Shoi";
        video1._length = 60;

        Comment comment2a = new Comment();
        comment2a._name = "Michael";
        comment2a._text = "I'm drooling!!!";

        Comment comment2b = new Comment();
        comment2b._name = "Brad";
        comment2b._text = "Is that Chinese?";

        Comment comment2c = new Comment();
        comment2c._name = "Ronny";
        comment2c._text = "Looks yummy!";

        Video video2 = new Video();
        video2._title = "My favourite hotpot in Melbourne";
        video2._author = "Dona";
        video2._length = 240;

        Comment comment3a = new Comment();
        comment3a._name = "Andrew";
        comment3a._text = "Looks like my kind of city";

        Comment comment3b = new Comment();
        comment3b._name = "Anu";
        comment3b._text = "Such a cool place";

        Comment comment3c = new Comment();
        comment3c._name = "Ivan";
        comment3c._text = "How much is the entrance at the Melbourne Skydeck?";

        Comment comment3d = new Comment();
        comment3d._name = "Julian";
        comment3d._text = "Is it a safe place at night?";

        Video video3 = new Video();
        video3._title = "Things to do in Melbourne";
        video3._author = "Vera";
        video3._length = 150;

        video1._comments.Add(comment1a);
        video1._comments.Add(comment1b);
        video1._comments.Add(comment1c);

        video2._comments.Add(comment2a);
        video2._comments.Add(comment2b);
        video2._comments.Add(comment2c);

        video3._comments.Add(comment3a);
        video3._comments.Add(comment3b);
        video3._comments.Add(comment3c);
        video3._comments.Add(comment3d);

        List<Video> videos = new List<Video>() { video1, video2, video3 };

        foreach (Video v in videos)
        {
            v.DisplayVideo();            
        }
    }
}