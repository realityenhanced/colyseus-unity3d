// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 

using Colyseus.Schema;

public class Player : Schema {
	[Type("ref", typeof(Camp))]
	public Camp camp = new Camp();

	[Type("boolean")]
	public bool connected = false;
}

