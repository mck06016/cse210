using System;

public class CompoundGoal : Goal
{
  // Description
  /*
  Provide for an opportunity to create Compound Goals that are made up of multiple unique simple goals. Each simple goal provides value, then completion of the Compound Goal also provides some value. 
  */

  // Member Variables
  List<SimpleGoal> _compound;
  private int _parts;

  // Getters & Setters
  public void SetParts(int parts)
  {
    _parts = parts;
  }


  // Constructors
  public CompoundGoal(string name, string description, int points, List<SimpleGoal> compound, int parts) : base(name, description, points)
  {

  }

  // Methods



}