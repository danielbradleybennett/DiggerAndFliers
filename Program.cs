using System;

namespace Diggers
{
  class Program
  {
    static void Main(string[] args)
    {

      BettaFish myBettaFish = new BettaFish()
      {
        Swimmer = true
      };


      Ants myAnts = new Ants()
      {
        Digger = true
      };
      CopperheadSnake myCopperhead = new CopperheadSnake()
      {
        Crawler = true
      };
      Earthworms myEarthworm = new Earthworms()
      {
        Crawler = true
      };
      Finches myFinches = new Finches()
      {
        Flier = true
      };
      Gerbils myGerbils = new Gerbils()
      {
        Digger = true
      };
      Mice myMice = new Mice();
      Parakeets myParakeets = new Parakeets();
      Terrapins myTerrapins = new Terrapins();
      TimberRattlesnake myRattlesnake = new TimberRattlesnake();

      SwimmersContainer mySwimmers = new SwimmersContainer();
      DiggersContainer myDiggers = new DiggersContainer();
      FliersContainer myFliers = new FliersContainer();
      CrawlersContainer myCrawlers = new CrawlersContainer();

      mySwimmers.Swimmers.Add(myTerrapins);
      mySwimmers.Swimmers.Add(myBettaFish);
      myDiggers.Diggers.Add(myEarthworm);
      myDiggers.Diggers.Add(myGerbils);
      myDiggers.Diggers.Add(myAnts);
      myDiggers.Diggers.Add(myMice);
      myFliers.Fliers.Add(myParakeets);
      myFliers.Fliers.Add(myFinches);
      myCrawlers.Crawlers.Add(myRattlesnake);
      myCrawlers.Crawlers.Add(myCopperhead);

      foreach (string digger in DiggersContainer)
      {

      }

    }
  }
}
