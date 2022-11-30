# IMDBMovieApp
This is a code first approch application 

step 1: SQL queries :

queres for insertion:

insert into Actors(actorName, bio, DOB, gender) values ('yash', 'kgf actor', '1989-02-14' , 'male')
insert into Actors(actorName, bio, DOB, gender) values ('sudeep', 'VR actor', '1979/12/15', 'male')
insert into Actors(actorName, bio, DOB, gender) values ('ramya', 'kannada actress', '1990/11/23', 'female')

insert into Producers(ProducerName, bio, DOB, company, gender) values ('rajamauli', 'bahu movie', '1978/09/13','prod com', 'male')
insert into Producers(ProducerName, bio, DOB, company, gender) values ('josh', 'dash movie', '1998/04/23','truck com', 'male')
insert into Producers(ProducerName, bio, DOB, company, gender) values ('manasa', 'kan movie', '1999/05/14','car com', 'female')

insert into Movies(movieName, plot, dateOfRelease, actorId, producerId, poster) values ('kgf', 'm show', '2022/05/25', 1, 10, 'img1')
insert into Movies(movieName, plot, dateOfRelease, actorId, producerId, poster) values ('VR', 'n show', '2022/05/22', 4, 11, 'img2')

step 2 : Database Migration: 
* Add-Migration initialMigration
* update-database

step 3 :
EndPoints created :

1) Get All movie list :
    this end point is used to get all the movies details present in the database
    response :
    ![image](https://user-images.githubusercontent.com/54896197/204797781-d7094a2a-fdee-4da1-a184-17d5a94c661c.png)

    {
    "movieId": 3,
    "movieName": "tree",
    "plot": "horror",
    "dateOfRelease": "2022-11-30T07:51:28.916",
    "poster": "img3",
    "actorId": 4,
    "producerId": 3,
    "actors": {
      "actorId": 4,
      "actorName": ramya,
      "bio": Kannada actress,
      "dob": 1990/11/23,
      "gender": Female
    },
    "producers": {
      "producerId": 3,
      "producerName": manasa,
      "bio": kan movie,
      "dob": 1999/05/14,
      "company": car comp,
      "gender": female
    }
    
2) Add new movies :
    this end point is used to add new movies
    response :
    ![image](https://user-images.githubusercontent.com/54896197/204798268-fc378b28-9913-47aa-9ca7-4336d99984a3.png)
{
  "movieName": "RRR",
  "plot": "fun",
  "dateOfRelease": "2022-11-30T12:26:07.196Z",
  "poster": "img4",
  "actorId": 2,
  "producerId": 3
}

3) Edit movies :
    this end point is used to edit the movie details
    response :
    ![image](https://user-images.githubusercontent.com/54896197/204798691-747be48d-c4b9-4dd4-a1f2-16a19aa1a83d.png)
  
    {
  "movieId": 1,
  "movieName": "Yes",
  "plot": "string",
  "dateOfRelease": "2022-11-30T12:28:46.816Z",
  "poster": "string",
  "actorId": 0,
  "producerId": 0,
  "actors": {
    "actorId": 0,
    "actorName": "string",
    "bio": "string",
    "dob": "2022-11-30T12:28:46.816Z",
    "gender": "string"
  },
  "producers": {
    "producerId": 0,
    "producerName": "string",
    "bio": "string",
    "dob": "2022-11-30T12:28:46.816Z",
    "company": "string",
    "gender": "string"
  }
}
    

