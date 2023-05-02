namespace MyAPI.Services;

public class RpgService
{
    private static IList<RpgEntity> database;

    static RpgService()
    {
        database = new List<RpgEntity>();
        database.Add(new RpgEntity(){ id = 0,name = "boss",lv = 999});
        database.Add(new RpgEntity(){ id = 1,name = "boss2",lv = 50});
        database.Add(new RpgEntity(){ id = 2,name = "boss3",lv = 80});
        database.Add(new RpgEntity(){ id = 3,name = "boss4",lv = 60});
        database.Add(new RpgEntity(){ id = 4,name = "boss5",lv = 10});
    }
    public RpgEntity Get(int id)
    {
        RpgEntity result = null;

        var db = from d in database
            where d.id == id
            select d;
        if (db.Any())
        {
            result = db.First();
        }

        return result;
    }
    //
    public RpgEntity Create(RpgEntity rpgEntity)
    {
        //RpgEntity result = null;

        rpgEntity.id = database.Max(x=>x.id)+1;
        
        database.Add(rpgEntity);

        return rpgEntity;
    }
}