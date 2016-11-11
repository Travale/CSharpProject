public class GameStateMachine {

    public enum GameStates {Start, Play, Walk, Fight, Help, Died, End}

        public static GameStates currentGameState = GameStates.Start;

    }