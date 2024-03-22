API Duel Monsters - Projet Blazor
Le projet API Duel Monsters est une application Web développée avec Blazor, qui permet aux utilisateurs d'interagir avec une API externe pour obtenir des informations aléatoires sur les cartes du jeu Duel Monsters (Yu-Gi-Oh!). L'application offre la possibilité de consulter les détails d'une carte, de l'ajouter aux favoris et de gérer ces favoris, y compris la quantité de chaque carte favorite.

Fonctionnalités
Affichage de Carte Aléatoire: Permet aux utilisateurs de consulter les détails d'une carte Duel Monsters obtenue aléatoirement depuis l'API externe.
Gestion des Favoris: Les utilisateurs peuvent ajouter des cartes à une liste de favoris, supprimer des cartes de cette liste et modifier la quantité de chaque carte favorite.
Persistance des Favoris: Les favoris et leurs quantités sont sauvegardés dans le stockage local du navigateur, permettant de les retrouver lors de la prochaine visite de l'utilisateur.
Technologie
Blazor: Un framework pour construire des applications web interactives avec C# plutôt que JavaScript.
System.Text.Json: Utilisé pour la sérialisation et la désérialisation des objets JSON.
LocalStorage: Pour la persistance des données côté client.
Architecture du Projet
Le projet est structuré autour de plusieurs fichiers C# et Razor principaux, organisés de la manière suivante :

CardApi.cs: Contient la logique d'interaction avec l'API externe, la gestion des cartes actuelles et favorites, ainsi que les méthodes pour ajouter, supprimer et ajuster la quantité de cartes.
Card.cs et CardInfo.cs: Définissent les modèles de données pour les cartes.
Pages Blazor (.razor): Fournissent l'interface utilisateur pour afficher les cartes, les favoris, et interagir avec l'application.
Comment Utiliser
Consulter une Carte Aléatoire:

Accédez à la page d'accueil et cliquez sur le bouton "Check" pour obtenir les détails d'une carte aléatoire.
Ajouter aux Favoris:

Avec une carte affichée, cliquez sur "Add Card" pour l'ajouter à vos favoris.
Gérer les Favoris:

Accédez à la page "/Favorites" pour voir votre liste de favoris. Ici, vous pouvez augmenter/diminuer la quantité d'une carte ou la supprimer des favoris.
Dépendances
.NET 6 ou supérieur.
Un navigateur web moderne capable d'exécuter Blazor.
Installation
Pour exécuter ce projet localement, suivez ces étapes :

Clonez le dépôt sur votre machine locale.
Ouvrez le dossier du projet dans votre IDE préféré (ex : Visual Studio).
Restaurez les paquets NuGet nécessaires.
Exécutez l'application.
Contribution
Les contributions sont les bienvenues ! N'hésitez pas à ouvrir des issues ou à proposer des pull requests si vous avez des suggestions d'amélioration ou des corrections.
