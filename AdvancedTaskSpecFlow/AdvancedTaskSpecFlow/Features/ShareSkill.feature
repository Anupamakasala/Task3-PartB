Feature: ShareSkill

User should add their skills on to the share skill page so that they can list and trade skills

@tag1
Scenario Outline: Add skills on the share skill page and be able to save skills
When I navigate to the share skill page
And I add '<Title>','<Description>','<Category>','<Subcategory>','<Addtags>','<Servicetype>','<Locationtype>','<Daysavailable>','<BeginDate>','<FinishDate>','<Starttime>','<Endtime>','<Skilltrade>','<Skilltags>','<Charge>','<Active>'to the page and save it
Then I should be able to see the skill listed
Examples: 
| Title         | Description          | Category               | Subcategory         | Addtags | ServiceType          | Locationtype | Daysavailable | Begindate | Finishdate | Starttime | Endtime | Skilltrade      | Skilltags  | Charge | Active |
| Ballet Dancer | I am a ballet dancer | Fun & Lifestyle  | Health, Nutrition & Fitness | Dance   | Hourly basis service | On-site      | Mon           | 10102023  | 10102024   | 0900      | 1230    | Skill-exchange | SQL Server | 0      | Active |
