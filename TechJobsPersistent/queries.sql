Select jobs.Id, jobs.Name, jobs.EmployerId, data_types
From information_schema.columns
Where table_name ='jobs';

