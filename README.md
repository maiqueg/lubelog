![image](https://github.com/hargata/lubelog/assets/155338622/545debcd-d80a-44da-b892-4c652ab0384a)

A self-hosted, open-source vehicle service records and maintainence tracker.

## Why
Because nobody should have to deal with a homemade spreadsheet or a shoebox full of receipts when it comes to vehicle maintainence.

## Dependencies
- Bootstrap
- LiteDB
- Bootstrap-DatePicker
- SweetAlert2
- CsvHelper
- Chart.js

## Running with Docker
- Clone this repository and inside the project folder execute:
```
docker build -t lubelogger .
```
- Run the Docker image that was created:
```
docker run -p5000:5000 -d --name lubelogger lubelogger
```
