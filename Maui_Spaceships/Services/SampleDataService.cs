using Maui_Spaceships.Models;

namespace Maui_Spaceships.Services
{
    public class SampleDataService
    {
        public async Task<IEnumerable<SpaceshipItem>> GetItems()
        {
            await Task.Delay(1000); // Artifical delay to give the impression of work

            var random = new Random().Next();

            var result = new List<SpaceshipItem>();

            result.Add(new SpaceshipItem
            {
                DisplayName = "Kreuzer 546-Klasse",
                MachineState = "In Bearbeitung",
                UpdateMessage = "Wartung notwendig",
                RegistrationState = "Verifziert"
            });

            result.Add(new SpaceshipItem
            {
                DisplayName = "Sternzerstörer Imperium-I-Klasse",
                MachineState = "Ausgeschaltet",
                UpdateMessage = "",
                RegistrationState = "Abgelehnt"
            });
            result.Add(new SpaceshipItem
            {
                DisplayName = "Sternjäger TIE/ln",
                MachineState = "In Bearbeitung",
                UpdateMessage = "",
                RegistrationState = "Verifziert"
            });
            result.Add(new SpaceshipItem
            {
                DisplayName = "Shuttle Lambda-Klasse T-4a",
                MachineState = "In Bearbeitung",
                UpdateMessage = "Update verfügbar",
                RegistrationState = "Ausstehend"
            });
            result.Add(new SpaceshipItem
            {
                DisplayName = "Todesstern",
                MachineState = "In Störung",
                UpdateMessage = "",
                RegistrationState = "Verifziert"
            });


            return result;
        }
    }

}
