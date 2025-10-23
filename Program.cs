
using TestProject.Challenge;
using TestProject.Exercise;
using TestProject.Helpers;

TimeSpend.DeltaSpendTime("DeltaTimeProject", static () =>
{

    TimeSpend.DeltaSpendTime("ConverIfElseToSwitch", () =>
    {
        ChallengerIfElseToSwitch c = new ChallengerIfElseToSwitch();
        c.Run();
    });

    TimeSpend.DeltaSpendTime("ExerciseFor", () => new ExerciseFor().Run());

    //TimeSpend.DeltaSpendTime("ValidateIntegerInput", () => new ValidateIntegerInput().Run());

    //TimeSpend.DeltaSpendTime("ValidateStringInput", () => new ValidateStringInput().Run());

    TimeSpend.DeltaSpendTime("ValidateContentOfString", () => new ValidateContentOfString().Run());

});

Console.ReadKey();
