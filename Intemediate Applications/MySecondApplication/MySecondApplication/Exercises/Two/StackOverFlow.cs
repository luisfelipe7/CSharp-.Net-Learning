using System;
using System.Collections.Generic;

namespace MySecondApplication.Exercises.Two
{
  public class StackOverFlow
  {
    private readonly List<Post> Posts;
    private double QuantityOfPosts;

    public StackOverFlow()
    {
      this.Posts = new List<Post>();
      this.QuantityOfPosts = 0;
    }

    public void AddPost(Post postToAdd)
    {
      if (postToAdd != null) {
        postToAdd.setId(this.QuantityOfPosts + 1);
        this.QuantityOfPosts += 1;
        this.Posts.Add(postToAdd);
        Console.WriteLine("\n Post Added Sucessfully");
      } else {
        Console.WriteLine("\n Post can't be added because is null");
      }
    }

    public void DisplayPosts()
    {
      Console.WriteLine("\n ---------------- Posts -----------------");
      foreach (var post in this.Posts) {
        post.displayInformation();
      }
    }

    public void ModifyPost(double postId, double votes)
    {
      Post postToModify = this.Posts.Find(x => x.getId() == postId);
      if (postToModify != null) {
        postToModify.Votes += votes;
        Console.WriteLine("\n Post was modified sucessfully");
      } else {
        Console.WriteLine("\n Post was not found");
      }
    }
  }
}
