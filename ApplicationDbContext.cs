using System;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions option) : base(options)
    {

        //this is a comment@ mikael thrash

	}
}
