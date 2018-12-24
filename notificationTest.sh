curl -X POST \
  http://localhost/api/nrs/ \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -H 'Postman-Token: af0530b8-42f0-4f4c-b6f6-f695ba532578' \
  -H 'cache-control: no-cache' \
  -d 'id=1234&channel=yourChannel&event=yourEvent&contactId=yourContactId&campaignId=yourCampaignId&campaignName=yourCampaignName'
