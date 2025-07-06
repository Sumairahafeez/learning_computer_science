#!/bin/bash

# Set your name and email
git config user.name "Sumaira hafeez"
git config user.email "sumairahafeezfp@gmail.com"

# Months to target
months=("01" "02" "03" "04" "05")  # Jan to May
days=("Tue" "Wed" "Fri")          # Targeted days

# Year to target
year=2024

# Create a new repo if not already one
if [ ! -d ".git" ]; then
    git init
fi

# Create a dummy file
touch heatmap.md

# Loop through each day from Jan 1 to May 31, 2024
start_date="$year-01-01"
end_date="$year-05-31"

current_date="$start_date"
while [ "$(date -d "$current_date" +%Y%m%d)" -le "$(date -d "$end_date" +%Y%m%d)" ]; do
    dow=$(date -d "$current_date" '+%a')  # Get day of week

    for d in "${days[@]}"; do
        if [ "$dow" == "$d" ]; then
            export GIT_AUTHOR_DATE="$current_date 12:00:00"
            export GIT_COMMITTER_DATE="$current_date 12:00:00"
            echo "Commit on $current_date" >> heatmap.md
            git add heatmap.md
            git commit -m "chore: commit on $current_date"
        fi
    done

    # Move to next day
    current_date=$(date -I -d "$current_date + 1 day")
done

echo "✅ Done creating commits on Tue/Wed/Fri from Jan to May 2024."
