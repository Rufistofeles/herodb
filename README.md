
# Hero DB

This is a small project to exemplify the consumption of an API using "Net 6".




## Demo

https://herodb.rufistofeles.dev/


## API Reference

This project uses the SuperHero API
https://superheroapi.com/

#### Get by Id

```http
  GET /api/access-token/character-id
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `access-token` | `string` | **Required**. Your API key |
| `character-id` | `string` | **Required**. character id |

#### Get item

```http
  GET /api/access-token/search/name
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `access-token` | `string` | **Required**. Your API key |
| `name`      | `string` | **Required**. character's name |




## Appendix

character's list: https://github.com/Rufistofeles/herodb/blob/master/Personajes.xlsx


## Authors

- [@rufistofeles](https://github.com/Rufistofeles)

