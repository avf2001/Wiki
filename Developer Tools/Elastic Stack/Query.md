Пример поискового запроса с использованием регулярного выражения
```json
GET /amp-*/_search
{
  "query": {
    "regexp": {
      "labels.address_sourceString": {
        "value": ".*КИЕВ.*"
      }
    }
  }
}
```
