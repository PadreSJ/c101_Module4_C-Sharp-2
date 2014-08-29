public abstract class SocialNetwork
{
  /// <summary>
  /// Email address of the user
  /// </summary>
  public virtual string EmailAddress { get; set; }
  /// <summary>
  /// When posting a public message, the number of characters allowed.
  /// </summary>
  public virtual int AllowedNumberOfCharacters
  {
    get
    {
    return 140;
    }
  }
 
  /// <summary>
  /// Login to the SocialNetwork
  /// </summary>
  /// <param name="emailAddress">Email Address used for login</param>
  /// <returns>Successful Login</returns>
  public abstract bool Login(string emailAddress);
 
  /// <summary>
  /// Post a public message
  /// </summary>
  /// <param name="message">Message to post</param>
  public abstract void Post(string message);
 
  /// <summary> 
  /// Post a Photo and a message to go along with it.
  /// </summary>
  /// <param name="photo">Bytes of a photo</param>
  /// <param name="message">Message to Post</param>
  public abstract void Post(byte[] photo, string message);
 
  /// <summary>
  /// Ask the Social network to return my details
  /// </summary>
  /// <returns>Return the details of the user</returns>
  public virtual string WhoAmI()
  {
    return EmailAddress;
  }
}
 
public class Twitter : SocialNetwork
{
 
  public override void Post(string message)
  {
  }
 
  public override void Post(byte[] photo, string message)
  {
  }

  public override bool Login(string emailAddress)
  {
  this.EmailAddress = emailAddress;
  return true;
  }
}
 
public abstract class SocialNetworkFactory
{
  public static SocialNetwork CreateSocialNetwork(string name)
  {
    name = name.ToUpperInvariant();
 
    switch(name)
    {
      case "TWITTER":
      return new Twitter();
 
      default:
      return new Twitter();
    }
  }
}
