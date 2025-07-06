import pandas as pd
import matplotlib as plt
import seaborn as sns
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler, LabelEncoder
# Load the dataset
titanic = pd.read_csv('./Titanic-Dataset.csv')
titanic.dropna(inplace=True)
titanic['Age'].fillna(titanic['Age'].median(), inplace=True)
titanic['Embarked'].fillna(titanic['Embarked'].mode()[0], inplace=True)
titanic.drop(columns=['Cabin'], inplace=True)
label_encoder = LabelEncoder()
for column in titanic.select_dtypes(include=['object']).columns:
    titanic[column] = label_encoder.fit_transform(titanic[column])
features = titanic.drop(columns=['Survived'])
target = titanic['Survived']
X = titanic[features.columns]
Y = titanic[target]
X_train, X_test, y_train, y_test = train_test_split(X, Y, test_size=0.2, random_state=42)
# Scale the features
