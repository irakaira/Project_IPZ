class Account
{
  private string name;
  private bool sex;/0-male 1-female
  protected int lvl;
  Account(string name,bool sex)
  {
    this.lvl=0;
    this.name=name;
    this.sex=sex;
  }
  string getName()
  {
    return this.name;
  }
  bool getSex()
  {
    return this.sex;
  }
  int getLvl()
  {
    return this.lvl;
  }
  void setName(string name)
  {
    this.name=name;
  }
  void setLvl()
  {
    lvl++;
  }
}
