#include "tasks.h"


void task_71a(void)
{
    std::string strN;
    std::cin >> strN;

    try
    {
        int n = std::stoi(strN);

        if (n > 0)
        {
            std::string word;
            std::vector<std::string> words(n);

            for (size_t i = 0; i < n; i++)
            {
                std::cin >> word;
                words[i] = word;
            }

            for (size_t i = 0; i < n; i++)
            {
                size_t wordSize = words[i].size();
                if (wordSize > 10)
                {
                    std::cout << words[i][0] << wordSize - 2 << words[i][wordSize - 1] << std::endl;
                }
                else
                {
                    std::cout << words[i] << std::endl;
                }
            }
        }
    }
    catch (std::logic_error)
    {
        return;
    }
}

void task_4a(void)
{
    std::string weightStr;
    std::cin >> weightStr;

    try
    {
        int weight = std::stoi(weightStr);

        if (weight % 2 == 0 && weight > 2)
        {
            std::cout << "YES";
        }
        else
        {
            std::cout << "NO";
        }
    }
    catch (std::invalid_argument)
    {
        std::cout << "NO";
        return;
    }
    catch (std::out_of_range)
    {
        std::cout << "NO";
        return;
    }
}