import pandas as pd
pro = pd.series([1,2,3])
data = {'X':[78,85,96,80,86], 'Y':[84,94,89,83,86],'Z':[86,97,96,72,83]}
df = pd.DataFrame(data, index = ['a','b','c'])
print(df.info()) # it provides the basic summary of th edf
df['Name','Place']