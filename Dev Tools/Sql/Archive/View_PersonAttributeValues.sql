/* List Person Attribute Values*/
SELECT 
       p.Id,
       p.FullName,
       a.Id [Attribute.Id],
       [v].[Value] [AttributeValue.Value],
       [a].[Key] [AttributeKey],       
       [ft].[Name] [FieldType.Name]
       
  FROM [AttributeValue] [v]
  join [Attribute] [a] on [a].[Id] = [v].[AttributeId]
  left join [EntityType] [e] on [e].[Id] = [a].[EntityTypeId]
  join [FieldType] [ft] on [ft].[Id] = [a].[FieldTypeId]
  join [Person] [p] on [v].[EntityId] = [p].[Id]
  where e.Name = 'Rock.Model.Person'
order by p.FullName

