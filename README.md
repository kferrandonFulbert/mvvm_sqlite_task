# Application de Gestionnaire de Tâches

Ceci est une application simple de gestionnaire de tâches développée en utilisant l'architecture MVVM (Modèle-Vue-ViewModel) avec C# et Windows Forms.

L'application de gestionnaire de tâches permet aux utilisateurs de créer, gérer et suivre des tâches. Chaque tâche possède un titre, une date de début, une date de fin et un statut de réalisation. L'application inclut un composant Timer pour mettre à jour automatiquement l'état de réalisation des tâches en fonction de leur date de fin.

## Fonctionnalités

- Ajouter de nouvelles tâches avec un titre, une date de début et une date de fin.
- Marquer les tâches comme terminées.
- Supprimer des tâches.
- Mise à jour automatique de l'état de réalisation des tâches en fonction de la date de fin grâce à un composant Timer.
- Les tâches sont affichées dans une DataGridView pour une visualisation et une gestion facilitées.

## Démarrage

Pour exécuter l'application de gestionnaire de tâches en local, suivez les étapes suivantes :

1. Clonez le dépôt :


2. Ouvrez le fichier de solution `TaskManager.sln` dans Visual Studio.

3. Construisez la solution pour restaurer les packages NuGet et compiler le projet.

4. Exécutez l'application depuis Visual Studio ou en exécutant le fichier exécutable généré.

## Dépendances

L'application de gestionnaire de tâches a les dépendances suivantes :

- .NET core 6.0.x ou version ultérieure.
- Windows Forms.
- Nugets : System.Data.SQLite.Core 1.0.17

## Amélioration

1- Finir le CRUD Gérer l'update et le delete.
2- Gérer le temps passé sur une tache.
3- Catégoriser les taches.

## Licence

L'application de gestionnaire de tâches est sous licence [MIT License](LICENSE).
