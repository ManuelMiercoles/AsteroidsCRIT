using System.Collections;
using System.Collections.Generic;

public interface IDamage 
{
    int health{get; set;}
    void ReciveDamage(int totalDamage);
} 
