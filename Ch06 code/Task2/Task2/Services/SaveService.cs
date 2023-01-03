namespace Task2.Services
{
    public class SaveService
    {
        public async Task SaveProgress(Guid gameid, int team, params object[] datatosave)
        {
        }
        public async Task SaveProgress_Score(Guid gameid, int team, List<DataModels.PointScoredModel> scores)
        {
        }
        public async Task SaveProgress_Fouls(Guid gameid, int team, List<DataModels.FoulModel> fouls)
        {
        }
        public async Task SaveProgress_Rebounds(Guid gameid, int team, List<DataModels.ReboundModel> rebounds)
        {
        }
        public async Task SaveProgress_Blocks(Guid gameid, int team, List<DataModels.BlockModel> blocks)
        {
        }

    }
}
