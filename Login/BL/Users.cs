using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Users
{
    private String name;
    private String prenume;
    private String username;
    private String role;
    private String pass;
    public Users(string username, string password, string name, string prenume, string role)
    {
        this.username = username;
        this.pass = password;
        this.name = name;
        this.prenume = prenume;
        this.role = role;

    }

    public String getRole()
    {
        return this.role;
    }
    private void Users_Load(object sender, EventArgs e)
    {

    }
 }


