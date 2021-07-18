using Forsaj.Models.Tables;
using Forsaj.Models.VM;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Servicies
{
    public class Search : ISearch
    {

        public List<PostVM> GetPostFilter(int? countryId, int? cityId, int? markaId, int? modelId, int? priceMax, int? priceMin, int? yearMax, int? yearMin)
        {
            List<PostVM> posts = new List<PostVM>();
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("usp_FirstSource", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    cmd.Parameters.AddWithValue("@markaId", markaId);
                    cmd.Parameters.AddWithValue("@modelId", modelId);
                    cmd.Parameters.AddWithValue("@priceMax", priceMax);
                    cmd.Parameters.AddWithValue("@priceMin", priceMin);
                    cmd.Parameters.AddWithValue("@yearIdMax", yearMax);
                    cmd.Parameters.AddWithValue("@yearIdMin", yearMin);
                    cmd.Parameters.AddWithValue("@dateTime30", DateTime.Now.AddDays(30));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            posts.Add(new PostVM
                            {
                                Id = int.Parse(reader["ID"].ToString()),
                                Currency = reader["VALUYTA"].ToString(),
                                Marka = reader["MARKA"].ToString(),
                                Model = reader["MODEL"].ToString(),
                                Power = int.Parse(reader["POWER"].ToString()),
                                Price = int.Parse(reader["PRICE"].ToString()),
                                Probeg = int.Parse(reader["PROBEG"].ToString()),
                                Url = reader["FIRST_IMAGE"].ToString(),
                                Year = int.Parse(reader["YEAR"].ToString()),
                                Count = int.Parse(reader["COUNT"].ToString()),
                                CreateDate = reader["CREATE_DATE"].ToString()

                            });
                        }
                    }
                }
            }

            return posts;
        }
    }
}
